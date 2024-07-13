using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ViewResult Login()
        {
            return View();
        }
        public ViewResult Validate()
        {
            string Name = Request["txtName"];
            string Password = Request["txtpwd"];
            if (Name == "Admin" && Password == "Admin@123")
            {
                Session["Name"] = Name;
                return View("Sucess");
            }
            else
            {
                ViewBag.Name = Name;
                return View("Failure");
            }
        }
    }
}