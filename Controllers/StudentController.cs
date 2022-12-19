using CustomFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomFilter.Controllers
{
        [Authorize]
        [ActionFilter]



        public class StudentController : Controller
        {
            // GET: Student
            [HttpGet]
            public ActionResult Index()
            {
                return View();
            }



            [HttpPost]
            public ActionResult Index(Student student)
            {
                return View();
            }
        }
    }