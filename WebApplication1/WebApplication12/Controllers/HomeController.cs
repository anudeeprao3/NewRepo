 using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class HomeController : Controller
    {
        Employee obj = new Employee();
        // GET: Home
        public ActionResult Index()
        {
            var response=obj.GetAllEmployes();
            return View(response);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            //step1-create view and filter single user and pass that value to view
            //step2-uncomment in index.cshtml
            //step3-create view here
            var singleuser = obj.GetAllEmployes().Find(obj => obj.eno == id);
            return View(singleuser);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection,Employee emp)
        {
            try
            {
                // TODO: Add insert logic here
                obj.createuser(emp);
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
            var singleuser = obj.GetAllEmployes().Find(obj => obj.eno == id);
            return View(singleuser);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit( FormCollection collection,Employee emp)
        {
            try
            {
                // TODO: Add update logic here
                obj.edituser(emp);
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
            var singleuser = obj.GetAllEmployes().Find(obj => obj.eno == id);
            return View(singleuser);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                obj.deleteuser(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
          
        }
       
    }
}
