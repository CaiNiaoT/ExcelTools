using ExcelTools.QRCodeControls;
using Microsoft.Office.Tools;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelTools
{
    public partial class ThisAddIn
    {
        public Dictionary<Excel.Workbook, QRViewerControl> qrControls = new Dictionary<Excel.Workbook, QRViewerControl>();
        public Dictionary<Excel.Workbook, CustomTaskPane> qrPanes = new Dictionary<Excel.Workbook, CustomTaskPane>();
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            new ABCToolsRibbon();
            this.Application.SheetSelectionChange += Application_sheetSelectionChange;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }
        private void Application_sheetSelectionChange(object sh, Excel.Range target)
        {
            string cellValue = target.Value2?.ToString() ?? "";
            var currentWindow = Globals.ThisAddIn.Application.ActiveWorkbook;

            if (qrControls.ContainsKey(currentWindow))
            {
                qrControls[currentWindow].ShowQRCode(cellValue, cellValue);
            }


        }
        public void addQRPane()
        {
            var currentBook = Globals.ThisAddIn.Application.ActiveWorkbook;
            if (!qrControls.ContainsKey(currentBook))
            {
                var qrViewer = new QRViewerControl();
                var myTaskPane = this.CustomTaskPanes.Add(qrViewer, "二维码显示区");
                qrControls.Add(currentBook, qrViewer);
                qrPanes.Add(currentBook, myTaskPane);
                myTaskPane.Visible = false; // 默认隐藏
            }
        }
        #region VSTO 生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
