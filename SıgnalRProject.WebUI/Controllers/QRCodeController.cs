using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO ;
using ZXing;
using ZXing.QrCode;
using ZXing.Windows.Compatibility;
using Microsoft.AspNetCore.Authorization;

namespace SıgnalRProject.WebUI.Controllers
{
    [Authorize]
    public class QRCodeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string value)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                QRCodeGenerator createQRCode = new QRCodeGenerator();
                QRCodeGenerator.QRCode squareCode = createQRCode.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
                using (Bitmap image = squareCode.GetGraphic(10))
                {
                    image.Save(memoryStream, ImageFormat.Png);
                    ViewBag.QrCodeImage = "data:image/png;base64," + Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult DecodeQRCode()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DecodeQRCode(IFormFile qrImage)
        {
            if (qrImage != null && qrImage.Length > 0)
            {
                using (var stream = qrImage.OpenReadStream())
                {
                    var reader = new BarcodeReader();
                    var result = reader.Decode(new Bitmap(stream));

                    if (result != null)
                    {
                        ViewBag.QrCodeValue = result.Text;
                    }
                    else
                    {
                        ViewBag.QrCodeValue = "QR kodu çözülemedi.";
                    }
                }
            }
            else
            {
                ViewBag.QrCodeValue = "Lütfen bir QR kod resmi yükleyin.";
            }

            return View();
        }
    }
}
