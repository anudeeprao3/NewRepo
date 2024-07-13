using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;

namespace WebApplication18.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //create view here
            return View();
        }
        public ActionResult Graph()
        {
            //declare using system.web.heplers;
            string[] _xAxis = { "paytm", "kotak", "hdfc", "tata", "infosys" };
            string[] _yAxis = { "480", "1672", "1836", "1036", "1100" };
            //here the chart is going on
            var bytes = new Chart (width: 5000, height: 1000)
            .AddSeries(
                       chartType:"column",
                       xValue: _xAxis,
                       yValues: _yAxis)
                .GetBytes("png");
            return File(bytes, "image/png");                                              
        }
    }
}