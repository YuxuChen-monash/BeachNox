using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AquaNox.Controllers
{

    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult BeachSafety()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Quiz()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Gear()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult BeachDay()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Map()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult BeachPlay()
        {
            ViewBag.Message = "Your contact page.";

            return View();

        }

        public ActionResult test()
        {
            ViewBag.Message = "Your contact page.";

            return View();

        }
    }


}