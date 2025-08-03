using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIRST.Controllers
{
    public class SECONDController : Controller
    {
        // GET: SECOND
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int num1, int num2)
        {
            ViewBag.Num1 = num1;
            ViewBag.Num2 = num2;
            ViewBag.Add = num1 + num2;
            ViewBag.Sub = num1 - num2;
            ViewBag.Mul = num1 * num2;
            ViewBag.Div = num1 / num2;

            return View();
        }
    }
}