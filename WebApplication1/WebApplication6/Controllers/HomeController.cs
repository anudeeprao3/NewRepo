using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [OutputCache(Duration = 20)]
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }
        public ActionResult Index1()
        {
            throw new NullReferenceException();
        }
        public ActionResult About()
        {
            return View();
        }
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize (Users = "nareshit@gmail.com")]
        public Action Result MyIndex()
        {
            return View();
        }
    }
}