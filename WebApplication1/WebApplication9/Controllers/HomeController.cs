using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;
using WebApplication9.Models;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            employee obj = new employee();
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
        public ActionResult Index2()
        {
            //One Action to Another Action

            // Create two Actions and craete view to Index2 Action
            //create tempdata object and assign values to tempdata
            //Use Redirect Action to index2
            //pass the values using tempdata (which was craeted in Index action) in Index2
            //use that tempdata in view
            TempData["value"] = "naresh it";
            return RedirectToAction("index3");
        }
        public ActionResult Index3()
        {
            string name = TempData["value"].ToString();
            return View();
        }


        public ActionResult index4()
        {
            // GET: Home
            //Craete two controller (Home, Employee) ,one model (Customer)
            // craete object to model class and assign values to model properties
            // Craete TempData object and pass the values
            //now pass the data from one controller to another controller
            //complete controller2 code and craete view for the same
           Customer obj = new Customer();
            obj.CustomerId= 1;
            obj.CustomerName = "naresh";
            obj.Country = "usa";
            TempData["myData"] = obj;
            return RedirectToAction("index","Employee");
        }
    }
}