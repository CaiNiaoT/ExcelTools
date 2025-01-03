using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelTools.QRCodeControls
{
    public partial class QRViewerControl : UserControl
    {
        public QRViewerControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 显示二维码
        /// </summary>
        /// <param name="qrCodeValue">二维码值</param>
        /// <param name="qrCodeTitle">二维码显示内容</param>
        public void ShowQRCode(string qrCodeValue, string qrCodeTitle)
        {
            if (!this.Visible)
                return;
            var img = QRCodeHelper.GenerateQRCode(qrCodeValue);
            this.pbQRCode.Image = img;
            this.lbQRCode.Text = $"{qrCodeTitle}";
        }

        private void QRViewerControl_VisibleChanged(object sender, EventArgs e)
        {
            var selection = Globals.ThisAddIn.Application.Selection;
            if (selection is Excel.Range range)
            {
                // 获取第一个单元格的值
                var value = range.Cells[1, 1].Value2?.ToString() ?? "";
                this.ShowQRCode(value, value);
            }
        }
    }
}
