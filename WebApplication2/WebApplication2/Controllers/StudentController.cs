﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public ViewResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddStudent(Student student)
        {
            return View("DisplayStudent", student);
        }


        [HttpGet]
        public ViewResult AddStudentST()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddStudentST(Student student)
        {
            return View("DisplayStudentST", student);
        }

        public PartialViewResult Header()
        {
            return PartialView("_Header");
        }



    }
}