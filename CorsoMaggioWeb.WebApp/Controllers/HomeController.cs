using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CorsoMaggioWeb.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            System.Threading.Thread.Sleep(3000);

            //Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return Content("home");
        }

        public ActionResult Profile()
        {
            System.Threading.Thread.Sleep(3000);
            return Content("profile");
        }

        public ActionResult Message()
        {
            System.Threading.Thread.Sleep(3000);

            return Content("message");
        }


        public ActionResult JsHistory()
        {
            return View();
        }

    }
}