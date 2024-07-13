using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication17.Models;
using static WebApplication17.Models.Employee;

namespace WebApplication17.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Employee obj = new Employee();
        public ActionResult Index()
        {
            List<SelectListItem> depList = new List<SelectListItem>();
            TempData["hobbiesValues"] = obj.GetHobbies();
            TempData.Keep();
            return View();
       
        }
    }
}