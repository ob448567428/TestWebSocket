using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWebSocket.Models;

namespace TestWebSocket.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string indicator)
        {
            Config.Indicator = indicator;
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
