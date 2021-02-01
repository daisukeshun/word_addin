
namespace w
{
    using System;
    using System.Data;
    using System.Data.Odbc;
    using System.Data.OleDb;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using Microsoft.Office.Interop;

    public partial class SelectionForm : Form
    {
        private string path = null;
        private DataSet excelData = null;
        private string selectedSheet = null;
        private string query = null;
        private OdbcConnection connection = null;
        private List<string> sheetNames = new List<string>();
        private List<string> selectedFields = new List<string>();
        private object applicationObject = null;
        private List<string> selectedRows = new List<string>();

        public SelectionForm(object applicationObject)
        {
            this.applicationObject = applicationObject;
        }
        public DataSet ExcelData { get => excelData; }
        public void SetApplicatioObject(object value) { applicationObject = value; }
        public SelectionForm()
        {
            InitializeComponent();
        }
        private void SelectionForm_Load(object sender, EventArgs e)
        {
            this.WorksheetsLabel.Visible = false;
            this.Worksheets.Visible = false;

            this.SelectAllFields.Visible = false;
            this.Fields.Visible = false;
            this.MoveFieldUp.Visible = false;
            this.MoveFieldDown.Visible = false;

            this.FilterRowLabel.Visible = false;
            this.FilterRow.Visible = false;

            this.SelectAllRows.Visible = false;
            this.Rows.Visible = false;

            this.SaveSelection.Visible = false;
            this.Size = new System.Drawing.Size(this.Width, 100);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private void PastTableFromData(int sheetIndex) //вставляет таблицу в Word
        {
            if (this.applicationObject == null) { return; }
            DataRowCollection rows = this.excelData.Tables[sheetIndex].Rows;    //количество строк в таблице 
            DataColumnCollection cols = this.excelData.Tables[sheetIndex].Columns; //количество столбцов в таблице

            var document = ((Microsoft.Office.Interop.Word.Application)this.applicationObject).ActiveDocument; //получение текущего документа Word
            var selection = ((Microsoft.Office.Interop.Word.Application)this.applicationObject).Selection;  //получение текущего документа Word
            var range = document.Range(selection.Start, selection.End);                                     //получение объекта для редактирования документа
            document.Tables.Add(range, rows.Count+1, cols.Count);                                             //добавление таблицы с нужным количеством строк и столбцов
            var table = document.Tables[document.Tables.Count];                                             //получение самой таблицы для вставки (странно, что отсчет начинается с 1)

            //задание видимых границ для таблицы
            table.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;    
            table.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;

            for (int i = 0; i < cols.Count; i++) //вставка названий полей в столбцы таблицы
            {
                table.Cell(1, i+1).Range.Text = cols[i].ToString(); //опять-таки, достаточно странно что индексы начинаются с 1
            }
            for (int i = 0; i < rows.Count; i++) //вставка остальных строк в таблицу
            {
                for (int j = 0; j < cols.Count; j++)
                {
                    table.Cell(i+2, j+1).Range.Text = rows[i][j].ToString();
                }
            }
        }
        private string BuildQueryStringForOneField(string fieldName, bool allowRepeat)
        {
            this.query = allowRepeat ? "select " : "select distinct ";
            this.query += $"`{fieldName}` ";
            this.query += "from ";
            this.query += $"[{this.selectedSheet}] ";
            return this.query;
        }
        private string BuildQueryStringForFields() //составляет строку запроса для получения данных из выбранных полей и таблицы
        {
            this.query = "select ";
            for (int i = 0; i < this.selectedFields.Count - 1; i++)
            {
                this.query += $"[{this.selectedFields[i]}], ";
            }
            this.query += $"[{this.selectedFields[this.selectedFields.Count - 1]}] ";
            this.query += "from ";
            this.query += $"[{this.selectedSheet}] ";

            if (this.FilterRow.SelectedItem != null)
            {
                this.query += "where ";
                for (int i = 0; i < this.selectedRows.Count - 1; i++)
                {
                    this.query += $"[{this.selectedSheet}].[{this.FilterRow.SelectedItem.ToString()}] = '{this.selectedRows[i]}' or ";
                }
                this.query += $"[{this.selectedSheet}].[{this.FilterRow.SelectedItem.ToString()}] = '{this.selectedRows[this.selectedRows.Count-1]}'";
            }
            return this.query;
        }
        private void GetExcelFilePath() //вызов диалога открытия файла
        {
            OpenFileDialog dialog = null;
            try
            {
                dialog = new OpenFileDialog
                {
                    Title = "Select Excel spreadsheet file",
                    Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"
                };
                dialog.ShowDialog();
                if(dialog.FileName != "") { this.path = dialog.FileName; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (dialog != null) { dialog.Dispose(); }
            }
        }
        private void CreateConnection() //открывает соединение с excel файлом
        {
            try
            {
                string connectionString = "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)}; DBQ=" + this.path;
                this.connection = new OdbcConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        private DataSet GetExcelData(string queryString) //осуществляет запрос и возвращает результат запроса
        {
            try
            {
                this.excelData = new DataSet();
                this.connection.Open();
                using (var adapter = new OdbcDataAdapter(queryString, this.connection)) { adapter.Fill(this.excelData); }
            }
            catch (OdbcException e)
            {
                //MessageBox.Show(e.ToString());
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.connection.Close();
            }
            return this.excelData;
        }
        private void selectAllItemsInCheckBoxList(CheckBox flag, CheckedListBox listBox)
        {
            if (flag.Checked) { 
                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    listBox.SetItemChecked(i, true);
                }
            }
        }
        private void SelectAllRows_CheckedChanged(object sender, EventArgs e) //выделяет все регионы
        {
            this.selectAllItemsInCheckBoxList(this.SelectAllRows, this.Rows);
        }
        private void SelectAllFields_CheckedChanged(object sender, EventArgs e) //выделяет все поля
        {
            this.selectAllItemsInCheckBoxList(this.SelectAllFields, this.Fields);
        }
        private void OpenFile_Click(object sender, EventArgs e) //при нажатии кнопки "открыть файл" 
        {
            this.sheetNames.Clear(); //очищаются выбранные поля
            this.Worksheets.SelectedItem = null; //очищается выбранная таблица
            this.GetExcelFilePath(); //получение пути до excel файла 
            this.SelectAllFields.Checked = false;
            this.SelectAllRows.Checked = false;

            if (this.path == null) { return; } //если путь не задается тогда не делаем ничего дальше

            this.CreateConnection();//создается соединение
            this.GetExcelSheetMeta();//получение имен таблиц в excel фале
            this.Worksheets.Items.Clear();
            this.Fields.Items.Clear();
            this.Worksheets.Items.AddRange(this.sheetNames.ToArray()); //включение полученных имен таблиц в ComboBox
            this.Worksheets.SelectedIndex = 0;

            this.WorksheetsLabel.Visible = true;
            this.Worksheets.Visible = true;

            this.FilterRowLabel.Visible = true;
            this.FilterRow.Visible = true;
            this.SelectAllRows.Visible = true;
            this.Size = new System.Drawing.Size(Width, 600);

            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
        }       
        private void SaveSelection_Click(object sender, EventArgs e) //при нажатии "сохранить"
        {

            //if (this.Worksheets.SelectedItem == null) { return; }
            try
            {
                if (this.Fields.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Не выбраны поля");
                    return;
                }
                if (this.Rows.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Не выбраны строки");
                    return;
                }

                this.GetSelectedItemsFromCheckListbox(this.selectedFields, this.Fields); //получение выделенных полей таблицы
                this.GetSelectedItemsFromCheckListbox(this.selectedRows, this.Rows); //получение выделенных регионов таблицы
                this.selectedSheet = this.Worksheets.SelectedItem.ToString(); //запоминает выбранную таблицу

                this.query = this.BuildQueryStringForFields();  //составление текста запроса к файлу excel
                this.excelData = this.GetExcelData(this.query); //сам запрос 

                if ( this.excelData != null && this.excelData.Tables.Count > 0 )
                {
                     this.PastTableFromData(0); //вставка таблицы в Word
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FilterRow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.FilterRow.SelectedItem == null) { return; }
            this.query = this.BuildQueryStringForOneField(this.FilterRow.SelectedItem.ToString(), false);

            this.excelData = this.GetExcelData(this.query);          //делаем запрос к для выбранного поля
            this.Rows.Items.Clear();                                 //очищаем поля в checkboxList'е
            if (this.excelData.Tables.Count > 0)
            {
                foreach (DataRow row in this.excelData.Tables[0].Rows)  //добавляем найденные строки в checkboxList
                {
                    if (row[0].ToString().Length > 0)
                    {
                        this.Rows.Items.Add(row[0].ToString());
                    }
                }
            }

            this.Rows.Visible = true;
            this.SaveSelection.Visible = true;
        }

        private string[] GetConnectionSchema(string collectionName, string rowName) //используется для получения имен полей о таблицах
        {       
            DataTable dt = this.connection.GetSchema(collectionName);
            string[] ret = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++) 
            {
                ret[i] = dt.Rows[i][rowName].ToString(); 
            }
            return ret;
        }
        private void GetExcelSheetMeta() 
        {
            try
            {
                this.connection.Open();
                if(this.connection.State == ConnectionState.Open)
                {
                    this.sheetNames.AddRange(this.GetConnectionSchema("Tables", "TABLE_NAME")); //получаем имена таблиц из файла excel
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Файл не был выбран.");
            }
            finally
            {
                if (this.connection != null) { this.connection.Close(); }
            }
        }
        private void GetSelectedItemsFromCheckListbox(List<string> selectedItems, CheckedListBox listBox)
        {
            for (int i = 0; i < listBox.Items.Count; i++) //получение выделенных полей таблицы
            {
                if (listBox.GetItemChecked(i)) { selectedItems.Add(listBox.Items[i].ToString()); }
            }
        }
        private void Worksheets_SelectedIndexChanged(object sender, EventArgs e) //при выборе другого листа excel файла изменяются и поля, которые можно выбрать
        {
            if (this.Worksheets.SelectedItem == null)
            {
                return;
            }
            this.selectedSheet = this.Worksheets.SelectedItem.ToString();
            this.query = $"select top 1 * from [{this.Worksheets.SelectedItem}]";

            this.excelData = this.GetExcelData(this.query);             //делаем запрос к первой строке таблицы
            this.Fields.Items.Clear();                                  //очищаем поля в checkboxList'е
            this.FilterRow.Items.Clear();
            this.FilterRow.SelectedItem = null;
            if (this.excelData.Tables.Count > 0)
            {
                foreach (var column in this.excelData.Tables[0].Columns)//добавляем найденные имена полей в checkboxList
                {
                    this.Fields.Items.Add(column.ToString());
                    this.FilterRow.Items.Add(column.ToString());
                }
            }
            this.FilterRow.SelectedIndex = 0;

            this.SelectAllFields.Visible = true;
            this.Fields.Visible = true;
            this.MoveFieldUp.Visible = true;
            this.MoveFieldDown.Visible = true;
        }

        private void moveSelectedListBoxItem(CheckedListBox listBox, int indexChange)
        {
            if (listBox.SelectedItem != null)
            {
                object selectedItem = listBox.SelectedItem;
                int selectedIndex = listBox.SelectedIndex;
                bool checkState = listBox.GetItemChecked(selectedIndex);
                listBox.Items.Remove(selectedItem);
                listBox.Items.Insert(selectedIndex - indexChange, selectedItem);
                listBox.SelectedIndex = selectedIndex - indexChange;
                listBox.SetItemChecked(listBox.SelectedIndex, checkState);
            }
        }
        private void MoveFieldUp_Click(object sender, EventArgs e)
        {
            if (this.Fields.SelectedIndex > 0) {
                this.moveSelectedListBoxItem(this.Fields, 1);
            }
        }
        private void MoveFieldDown_Click(object sender, EventArgs e)
        {
            if (this.Fields.SelectedIndex < this.Fields.Items.Count - 1) { 
                this.moveSelectedListBoxItem(this.Fields, -1);
            }
        }
    }
}
