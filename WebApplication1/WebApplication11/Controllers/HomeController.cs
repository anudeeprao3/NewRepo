﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication11.Controllers
{
    public class HomeController : Controller
    {
       [Route("Mvctest")]
        public ActionResult Index()
        {
            return View();
        }
    }
}