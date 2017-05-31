using CorsoMaggioWeb.Logic;
using CorsoMaggioWeb.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CorsoMaggioWeb.WebApp.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }


        public ActionResult List()
        {
            using (var svc = new CustomerServices())
            {
                var products = svc.ListCustomers();

                return View(products);
            }
        }

        public ActionResult CountProducts()
        {
            using(var ctx = new NorthwindContext())
            {
                return Content("> " + ctx.Products.Count());
            }
        }


    }
}