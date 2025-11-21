using Microsoft.Office.Tools.Ribbon;
namespace ExcelTools
{
    public partial class ABCToolsRibbon
    {
        private void RibTest_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void btnViewQRCode_Click(object sender, RibbonControlEventArgs e)
        {
            var currentWorkbook = Globals.ThisAddIn.Application.ActiveWorkbook;

            if (!Globals.ThisAddIn.qrPanes.ContainsKey(currentWorkbook))
            {
                Globals.ThisAddIn.addQRPane();

            }
            Globals.ThisAddIn.qrPanes[currentWorkbook].Visible = !Globals.ThisAddIn.qrPanes[currentWorkbook].Visible;
        }
    }
}
