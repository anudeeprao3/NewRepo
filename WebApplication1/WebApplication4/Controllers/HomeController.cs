using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public List<employee> empList = new List<employee>
        {
            new employee
            {
                userid = 1,
                username="anudeep",
                company="tcs"
            },
            new employee
            {
                userid = 2,
                username="sandeep",
                company="accenture"
            },
            new employee
            {
                userid = 3,
                username="mandeep",
                company="dlx"
            },
        };

        public ActionResult Index()
        {
           var employees = from e in empList orderby e.userid select e;
           
            return View(employees);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create(int userid)
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(employee obj)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = empList.Single(m => m.userid == id);
            return View(employee);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                //controller dummy list
                var employee = empList.Single(m => m.userid == id);
                if (TryUpdateModel(employee))
                {
                    //To Do:- database code
                    return RedirectToAction("Index");
                }
                return View(employee);
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
