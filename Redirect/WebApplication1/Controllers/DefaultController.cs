using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        
        //Redirect Result
        
        public RedirectResult Index()
        {
            return Redirect("http://www.facebook.com");
        }
    }
}