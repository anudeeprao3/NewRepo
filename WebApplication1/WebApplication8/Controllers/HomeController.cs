using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            employee obj =new employee();
            obj.userId = 1;
            obj.userName = "naresh it";
            obj.Company = "tcs";
            ViewData["msg"] = obj;
            return View();
        }
        public ActionResult Index1()
        {
            employee obj = new employee();
            obj.userId = 1;
            obj.userName = "naresh it";
            obj.Company = "tcs";
            ViewBag.msg = obj;
            return View();
           
        }
    }
}