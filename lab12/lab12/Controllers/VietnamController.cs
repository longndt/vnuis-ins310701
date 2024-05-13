using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab12.Controllers
{
    public class VietnamController : Controller
    {
        // GET: Vietnam
        public ActionResult Index()
        {
            return View();
        }

        //web url: localhost:PORT/Vietnam/Hanoi
        public ActionResult Hanoi()
        {
            //pass data from Controller (Backend) to View (Frontend)
            //1st way: ViewBag
            ViewBag.HN = "Hà Nội is the capital of Việt Nam";

            //2nd way: ViewData
            ViewData["Year"] = DateTime.Now.Year.ToString();

            //view location: Views/Vietnam/Hanoi.cshtml
            return View();
        }

        //web url: localhost:PORT/Vietnam/Danang
        public ActionResult Danang()
        {
            //view location: Views/Vietnam/Danang.cshtml
            return View();
        }
    }
}