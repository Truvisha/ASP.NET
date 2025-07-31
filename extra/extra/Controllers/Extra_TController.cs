using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace extra.Controllers
{
    public class Extra_TController : Controller
    {
        // GET: Extra_T
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Digit()
        {
            ViewBag.Value = 22;
            ViewBag.firstvalue = ViewBag.Value / 10;
            ViewBag.secondvalue = ViewBag.Value % 10;
            ViewBag.multiplication = ViewBag.firstvalue * ViewBag.secondvalue;
            return View();
        }
    }
}