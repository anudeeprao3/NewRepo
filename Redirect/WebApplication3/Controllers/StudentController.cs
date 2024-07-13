using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication3.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

        // Redirect To Route Result
        public RedirectToRouteResult index()
        {
            return RedirectToRoute(new { Controller = "Employee", action = "index3" });
        }
    }
}