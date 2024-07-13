using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        //Redirect To Action Result
        public RedirectToRouteResult index()
        {
            return RedirectToRoute(new { Controller = "Home", action = "index2" });
        }
        public ContentResult Index2()
        {
            return Content("iam from redirect to route with in the same controller");
        }
    }
}