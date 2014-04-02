using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPractice.Controllers
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

        public ActionResult Management()
        {
            ViewBag.Message = "Your management page.";

            return View();
        }

        public ActionResult Information()
        {
            ViewBag.Message = "Your information page.";

            return View();
        }

        public ActionResult CommonRoom()
        {
            ViewBag.Message = "Your commonroom page.";

            return View();
        }

        public ActionResult Location()
        {
            ViewBag.Message = "Your location page.";

            return View();
        }
    }
}