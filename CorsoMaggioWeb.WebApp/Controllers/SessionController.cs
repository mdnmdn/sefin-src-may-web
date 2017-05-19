using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace CorsoMaggioWeb.WebApp.Controllers
{
    [SessionState(System.Web.SessionState.SessionStateBehavior.ReadOnly)]
    public class SessionController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Image(string id)
        {
            var val = Session["image"];
            Thread.Sleep(1000);

            return File("~/content/images/rabbid.jpg","image/jpeg");
        }

    }
}