using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using curd.Models;

namespace curd.Controllers
{
    public class HomeController : Controller
    {
        public static List<employee> emplist = new List<employee>
        {
            new employee
            {
                userid=1,
                username="anudeep",
                company="tcs"
            },
            new employee
            {
                userid=2,
                username="sandeep",
                company="accenter"
            },
            new employee
            {
                userid=3,
                username="mandeep",
                company="dlx"
            },
        };
        


        // GET: Home
        public ActionResult Index()
        {
            var employess = from e in emplist orderby e.userid select e;
            return View(employess);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            var employee = emplist.Single(m => m.userid == id);
            return View(employee);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection,employee emp) 
        {
            try
            {
                // TODO: Add insert logic here
                emplist.Add(emp);
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

            var employee = emplist.Single(m => m.userid == id);
            return View(employee);
            
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var employee = emplist.Single(m => m.userid == id);
                TryUpdateModel(employee);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            var employee = emplist.Single(m => m.userid == id);
            return View(employee);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                emplist.RemoveAll(m=> m.userid == id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
