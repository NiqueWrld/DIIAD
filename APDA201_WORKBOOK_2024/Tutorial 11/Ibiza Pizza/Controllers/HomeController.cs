using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ibiza_Pizza.Models;

namespace Ibiza_Pizza.Controllers
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

        public ActionResult Calculate()
        {
            ViewBag.Message = "Your Calculate page.";

            return View();
        }

        [HttpPost]
        public ActionResult Calculate(Calculate calc)
        {
            ViewBag.Message = "Your Calculate page.";
            calc.amountSpent = calc.calcAmountSpent();
            calc.change = calc.calcChange();
            return View(calc);
        }

    }
}