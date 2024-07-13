using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
       
        public ContentResult Index3()
        {
            return Content("iam from redirect to route result with other controller");
        }
    }
}