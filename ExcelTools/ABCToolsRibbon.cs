using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
namespace ExcelTools
{
    public partial class ABCToolsRibbon
    {
        private void RibTest_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void btnViewQRCode_Click(object sender, RibbonControlEventArgs e)
        {
            if (Globals.ThisAddIn.myTaskPane == null)
            {
                Globals.ThisAddIn.addQRPane();
            }
            Globals.ThisAddIn.myTaskPane.Visible = !Globals.ThisAddIn.myTaskPane.Visible;
        }
    }
}
