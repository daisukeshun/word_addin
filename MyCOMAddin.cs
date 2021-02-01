using System;
using System.Runtime.InteropServices;

namespace w
{
    using Extensibility;
    using Microsoft.Office.Core;
    using System.Reflection;
    using Office = Microsoft.Office.Core;
    using Word = Microsoft.Office.Interop.Word;
    using Microsoft.Win32;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using System.Data.Odbc;
    using System.Data.OleDb;
    using System.Data;

    [Guid("C3293832-F6D2-42FD-A96E-847B48D098EC")]
    [ComVisible(true)]
    [ProgId("w.MyCOMAddin")]
    public class MyCOMAddin : IDTExtensibility2, Office.IRibbonExtensibility
    {
        private object applicationObject;
        private object addInInstance;

        private SelectionForm selectionForm = null; //объект диалогового окна

        public void OnConnection(object application, Extensibility.ext_ConnectMode connectMode, object addInInst, ref System.Array custom)
        {
            applicationObject = application;
            addInInstance = addInInst;

            if (connectMode != Extensibility.ext_ConnectMode.ext_cm_Startup)
            {
                OnStartupComplete(ref custom);
            }

        }
        public void OnDisconnection(Extensibility.ext_DisconnectMode disconnectMode, ref System.Array custom)
        {
            if (disconnectMode != Extensibility.ext_DisconnectMode.ext_dm_HostShutdown)
            {
                OnBeginShutdown(ref custom);
            }
            applicationObject = null;
        }
        public void OnAddInsUpdate(ref System.Array custom) { }
        public void OnStartupComplete(ref System.Array custom) { }
        public void OnBeginShutdown(ref System.Array custom)
        {
            object omissing = System.Reflection.Missing.Value;
        }
        public void InsertTableBtn_Click(Office.IRibbonControl control) //при нажатии кнопки "insert table"
        {
            using(selectionForm = new SelectionForm()) //используем диалоговое окно 
            {
                selectionForm.SetApplicatioObject(this.applicationObject);
                selectionForm.ShowDialog();                 //показываем окно
            }

        }
        public string GetCustomUI(string RibbonID)
        {
            try
            {
                return w.CustomMenu.customUI;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public System.Drawing.Bitmap GetInsertTableBtnImage(Office.IRibbonControl control)
        {
            return w.CustomMenu.insertTable;
        }
    }
}
