using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Automatica.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /* A comment added to demonstrate Git changes.
             * It works great.
             * Please delete this in your next commit.
             */
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
