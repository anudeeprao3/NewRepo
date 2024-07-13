using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QRCoder;
using WebApplication16.Models;
using static QRCoder.PayloadGenerator;

namespace WebApplication16.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult CreateQRCode()
        {
            //create view here using template:empty
            return View(new QRCodeModel());
        }
        [HttpPost]
        public ActionResult CreateQRCode(QRCodeModel qRCodeModel)
        {
            Payload payload = new Url(qRCodeModel.QRCodeText);
            QRCodeGenerator codeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = codeGenerator.CreateQrCode(payload);
            QRCoder.PngByteQRCode pngByte = new PngByteQRCode(qRCodeData);
            var QrByte = pngByte.GetGraphic(20);
            string base64Url = Convert.ToBase64String(QrByte);
            qRCodeModel.QRImageUrl = "data:image/png;base64," + base64Url;
            return View("CreateQRCode", qRCodeModel);
        }
    }
}