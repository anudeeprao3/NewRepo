using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult Register()
        {
            return View();
        }
        public ViewResult Login()
        {
            return View();
        }
        public ViewResult ForgotPassword()
        {
            return View();
        }
        public ViewResult ResetPassword()
        {
            return View();
        }
        public ViewResult Contact()
        {
            return View();
        }
        public ViewResult about()
        {
            return View();
        }
        public ViewResult Mission()
        {
            return View("~/Views/Test/Mission.cshtml");
        }



    }
}