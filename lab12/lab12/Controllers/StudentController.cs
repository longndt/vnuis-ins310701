using lab12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab12.Controllers
{
    public class StudentController : Controller
    {
        //render add new student form
        public ActionResult Add()
        {
            return View();
        }

        //get input from above form
        //pass information to view for displaying
        public ActionResult Index(Student student)
        {
            ViewBag.Student = student;
            return View();
        }
    }
}