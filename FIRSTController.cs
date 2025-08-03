using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIRST.Controllers
{
    public class FIRSTController : Controller
    {
        // GET: FIRST
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            //ViewBag.name = "pooja";
            int num1 = 20;
            int num2 = 10;
            int result = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            int div = num1 / num2;

            ViewBag.Num1 = num1;
            ViewBag.Num2 = num2;
            ViewBag.Result = result;
            ViewBag.Sub = sub;
            ViewBag.Multiply = mul;
            ViewBag.Div = div;




            return View();
        }
    }
}