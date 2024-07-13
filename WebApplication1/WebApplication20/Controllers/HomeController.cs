using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaptchaMvc.HtmlHelpers;

namespace WebApplication18.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //create view template:empty
            return View();
        }
        [HttpPost]
        public ActionResult Index(string empty)
        {
            //code for validating the captcha
            if (this.IsCaptchaValid("captcha is not valid !"))
            {
                return RedirectToAction("ThankYouPage");
            }
                
               
            
            ViewBag.ErrMessage = "error:captcha is not valid.";
            return View();
        }
        public ActionResult ThankYouPage()
        {
            return View();
        }
    }
}