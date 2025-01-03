using QRCoder;
using System.Drawing;
using System.IO;
public class QRCodeHelper
{
    public static Bitmap GenerateQRCode(string content)
    {
        using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
        {
            // 创建二维码数据
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);

            // 通过二维码数据生成图像
            using (QRCode qrCode = new QRCode(qrCodeData))
            {
                // 获取二维码图像
                Bitmap qrCodeBitmap = qrCode.GetGraphic(20);
                return qrCodeBitmap;
            }
        }
    }
}
