using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Employee obj = new Employee();
        public ActionResult Index()
        {
            List<SelectListItem>depList= new List<SelectListItem>();
            depList.Add(new SelectListItem() { Text = "select dept", Value = "0" });
            foreach (var item in obj.DepartmentNames.ToList())
            {
                depList.Add(new SelectListItem() { Text = item });
            }
            TempData["depertmentValues"] = depList;
            TempData.Keep();
            TempData["hobbiesValues"] = obj.Hobbies;
            TempData.Keep();
            return View();
        }
        //radio button,checkbox,gender we will go with form collection because we are not using for here
        //if we use for for control then modelbinding will automatically happen
        [HttpPost]
        public ActionResult Index(FormCollection collection,string gender,Employee emp)
        {
            emp.DeptName = collection["dept"];
            emp.Gender = gender;
            string val = string.Empty;
            foreach(var item in emp.Hobbies)
            {
                if (collection[item].ToString().Contains("true"))
                {
                    val = val + "," + item;
                }
            }
            emp.Hobby = val;
            emp.AddEmployee(emp);
            ViewBag.message = "sucess";
            ModelState.Clear();
            return View();
        }
    }
}