
namespace w
{
    partial class SelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.Worksheets = new System.Windows.Forms.ComboBox();
            this.SaveSelection = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.SelectAllFields = new System.Windows.Forms.CheckBox();
            this.WorksheetsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Fields = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.MoveFieldUp = new System.Windows.Forms.Button();
            this.MoveFieldDown = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Cancel = new System.Windows.Forms.Button();
            this.Rows = new System.Windows.Forms.CheckedListBox();
            this.SelectAllRows = new System.Windows.Forms.CheckBox();
            this.FilterRow = new System.Windows.Forms.ComboBox();
            this.FilterRowLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // Worksheets
            // 
            this.Worksheets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Worksheets.FormattingEnabled = true;
            this.Worksheets.Location = new System.Drawing.Point(3, 32);
            this.Worksheets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Worksheets.Name = "Worksheets";
            this.Worksheets.Size = new System.Drawing.Size(498, 24);
            this.Worksheets.TabIndex = 7;
            this.Worksheets.SelectedIndexChanged += new System.EventHandler(this.Worksheets_SelectedIndexChanged);
            // 
            // SaveSelection
            // 
            this.SaveSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveSelection.Location = new System.Drawing.Point(164, 12);
            this.SaveSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveSelection.Name = "SaveSelection";
            this.SaveSelection.Size = new System.Drawing.Size(155, 23);
            this.SaveSelection.TabIndex = 6;
            this.SaveSelection.Text = "Сохранить";
            this.SaveSelection.UseVisualStyleBackColor = true;
            this.SaveSelection.Click += new System.EventHandler(this.SaveSelection_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFile.Location = new System.Drawing.Point(3, 12);
            this.OpenFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(155, 23);
            this.OpenFile.TabIndex = 6;
            this.OpenFile.Text = "Открыть книгу Excel";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SelectAllFields
            // 
            this.SelectAllFields.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectAllFields.AutoSize = true;
            this.SelectAllFields.Location = new System.Drawing.Point(177, 64);
            this.SelectAllFields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectAllFields.Name = "SelectAllFields";
            this.SelectAllFields.Size = new System.Drawing.Size(149, 21);
            this.SelectAllFields.TabIndex = 4;
            this.SelectAllFields.Text = "Выбрать все поля";
            this.SelectAllFields.UseVisualStyleBackColor = false;
            this.SelectAllFields.CheckedChanged += new System.EventHandler(this.SelectAllFields_CheckedChanged);
            // 
            // WorksheetsLabel
            // 
            this.WorksheetsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WorksheetsLabel.AutoSize = true;
            this.WorksheetsLabel.Location = new System.Drawing.Point(232, 6);
            this.WorksheetsLabel.Name = "WorksheetsLabel";
            this.WorksheetsLabel.Size = new System.Drawing.Size(40, 17);
            this.WorksheetsLabel.TabIndex = 3;
            this.WorksheetsLabel.Text = "Лист";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.WorksheetsLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SelectAllFields, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Worksheets, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.Rows, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.SelectAllRows, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.FilterRow, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.FilterRowLabel, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 612);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel3.Controls.Add(this.Fields, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 92);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(498, 179);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // Fields
            // 
            this.Fields.AllowDrop = true;
            this.Fields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fields.FormattingEnabled = true;
            this.Fields.Location = new System.Drawing.Point(3, 2);
            this.Fields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fields.Name = "Fields";
            this.Fields.Size = new System.Drawing.Size(439, 175);
            this.Fields.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.MoveFieldUp, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.MoveFieldDown, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(448, 56);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(47, 66);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // MoveFieldUp
            // 
            this.MoveFieldUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveFieldUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveFieldUp.Location = new System.Drawing.Point(3, 2);
            this.MoveFieldUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoveFieldUp.Name = "MoveFieldUp";
            this.MoveFieldUp.Size = new System.Drawing.Size(41, 29);
            this.MoveFieldUp.TabIndex = 0;
            this.MoveFieldUp.Text = "▲";
            this.MoveFieldUp.UseVisualStyleBackColor = true;
            this.MoveFieldUp.Click += new System.EventHandler(this.MoveFieldUp_Click);
            // 
            // MoveFieldDown
            // 
            this.MoveFieldDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveFieldDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveFieldDown.Location = new System.Drawing.Point(3, 35);
            this.MoveFieldDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoveFieldDown.Name = "MoveFieldDown";
            this.MoveFieldDown.Size = new System.Drawing.Size(41, 29);
            this.MoveFieldDown.TabIndex = 1;
            this.MoveFieldDown.Text = "▼";
            this.MoveFieldDown.UseVisualStyleBackColor = true;
            this.MoveFieldDown.Click += new System.EventHandler(this.MoveFieldDown_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.SaveSelection, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.OpenFile, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Cancel, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 555);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(483, 47);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.Location = new System.Drawing.Point(325, 12);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(155, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Rows
            // 
            this.Rows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rows.FormattingEnabled = true;
            this.Rows.Location = new System.Drawing.Point(3, 365);
            this.Rows.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(498, 179);
            this.Rows.TabIndex = 8;
            // 
            // SelectAllRows
            // 
            this.SelectAllRows.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectAllRows.AutoSize = true;
            this.SelectAllRows.Location = new System.Drawing.Point(171, 337);
            this.SelectAllRows.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectAllRows.Name = "SelectAllRows";
            this.SelectAllRows.Size = new System.Drawing.Size(162, 21);
            this.SelectAllRows.TabIndex = 4;
            this.SelectAllRows.Text = "Выбрать все строки";
            this.SelectAllRows.UseVisualStyleBackColor = false;
            this.SelectAllRows.CheckedChanged += new System.EventHandler(this.SelectAllRows_CheckedChanged);
            // 
            // FilterRow
            // 
            this.FilterRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterRow.FormattingEnabled = true;
            this.FilterRow.Location = new System.Drawing.Point(3, 306);
            this.FilterRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilterRow.Name = "FilterRow";
            this.FilterRow.Size = new System.Drawing.Size(498, 24);
            this.FilterRow.TabIndex = 5;
            this.FilterRow.SelectedIndexChanged += new System.EventHandler(this.FilterRow_SelectedIndexChanged);
            // 
            // FilterRowLabel
            // 
            this.FilterRowLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FilterRowLabel.AutoSize = true;
            this.FilterRowLabel.Location = new System.Drawing.Point(186, 279);
            this.FilterRowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FilterRowLabel.Name = "FilterRowLabel";
            this.FilterRowLabel.Size = new System.Drawing.Size(131, 17);
            this.FilterRowLabel.TabIndex = 12;
            this.FilterRowLabel.Text = "Поле для фильтра";
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 612);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор элементов таблицы";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.ComboBox Worksheets;
        private System.Windows.Forms.Button SaveSelection;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.CheckBox SelectAllFields;
        private System.Windows.Forms.Label WorksheetsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckedListBox Fields;
        private System.Windows.Forms.CheckBox SelectAllRows;
        private System.Windows.Forms.CheckedListBox Rows;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button MoveFieldUp;
        private System.Windows.Forms.Button MoveFieldDown;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox FilterRow;
        private System.Windows.Forms.Label FilterRowLabel;
    }
}