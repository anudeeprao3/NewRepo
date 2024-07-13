using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // view result
        public ViewResult Index1()
        {
            return View();
        }
        //partial view
        public PartialViewResult Index2()
        {
            return PartialView("Second View");
        }
        //content
        public ContentResult Index3()
        {
            return Content("Some content");
            //return Content("<html><body>Hello World</body></html>");
            //return Content("<script language='javascript' type='text/javascript'>alert('I am from JAva script!');</script>");
        }
        //EmptyResult
        public EmptyResult Index4()
        {
            return new EmptyResult();
        }
        //FileResult
        public FileResult Index5()
        {
            var path = "C:\\Users\\dell\\Desktop\\MVC (1).pdf";
            return File(path, "text/plain");
        }
        //JsonResult
        public JsonResult Index6()
        {
            return Json(new { Name = "Naresh It", ID = 1 }, JsonRequestBehavior.AllowGet);
        }
        // HttpStatusCode
        public HttpStatusCodeResult Index7()
        {
            return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
        }
    }
}