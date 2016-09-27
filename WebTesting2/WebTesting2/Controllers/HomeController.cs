using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTesting2.Controllers
{
    public class HomeController : Controller
    {
        public string Text()
        {
            return "Hello! (from the webserver)";
        }
        //
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }
    }
}