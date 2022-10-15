using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FloatingPillars.Controllers
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
        public ActionResult PropertiesDetails()
        {
            ViewBag.Message = "Your PropertiesDetails page.";

            return View();
        }
        public ActionResult PropertiesRightSidebar()
        {
            ViewBag.Message = "Your PropertiesRightSidebar page.";

            return View();
        }
    }
}