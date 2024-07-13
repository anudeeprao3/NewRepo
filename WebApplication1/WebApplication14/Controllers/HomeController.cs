using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //create view here template:epty
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee emp ,string csharp, string java, string php ) 
        {
            string course = string.Empty;

            if(csharp=="true")
            {
                course = course + "c#" + ",";
            }
            if (java == "true")
            {
                course = course + "c#" + ",";
            }
            if (php == "true")
            {
                course = course + "c#" + ",";
            }
            emp.Course = course;
            Employee obj = new Employee();
            ViewBag.Message = "user created";
            obj.AddEmployee(emp);
            return View();
        }
    }
}










