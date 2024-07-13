using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        //create controller
        //create model and add properties
        //create dummy data method
        //call the method in side controller
       
       public ActionResult Index() 
        {
            return View();
        }
        [HttpGet]
        public JsonResult Index1()
        {
            Employee1 obj = new Employee1();
            var response = obj.GetEmployeesData();
            return Json(response, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index2()
        {
            Employee2 emp = new Employee2();
            var response = emp.GetEmployeesData();
            return View(response);
        }
    }
}