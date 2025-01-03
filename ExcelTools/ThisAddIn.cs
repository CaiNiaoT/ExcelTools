using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;
using System.Windows.Controls;
using ExcelTools.QRCodeControls;
using Microsoft.Office.Tools;

namespace ExcelTools
{
    public partial class ThisAddIn
    {
        public CustomTaskPane myTaskPane;
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

            // 更新任务窗格内容
            if (myTaskPane != null && myTaskPane.Visible && myTaskPane.Control is QRViewerControl control)
            {
                control.ShowQRCode(cellValue, cellValue);
            }
        }
        public void addQRPane()
        {
            if (this.myTaskPane == null)
            {
                var qrViewer = new QRViewerControl();
                myTaskPane = this.CustomTaskPanes.Add(qrViewer, "二维码显示区");
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
