using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using WebApplication10.Models;


namespace WebApplication10.Controllers
{
    public class HomeController : Controller
    {
       //step1-create controller and model
       //step2-declare properties and write the code for list of dummy users
       //step3-inside your controller create object to model class
       //step4-assign dumy values to your temp data
       //step5-create view and write logic for displaying list of user using tempdata
        public ActionResult Index()
        {
            Customer obj=new Customer();
            var data = obj.GetCustomers();
            TempData["MyData"] = data;
            return View();
        }
    }
}