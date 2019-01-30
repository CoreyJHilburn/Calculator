using InComculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InComculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Calculator";
            return View();
        }

        [HttpPost]
        public JsonResult Calculate(Calculator form)
        {
            double? result = null;
            switch(form.ID)
            {
                case 1: result = form.Num1 + form.Num2;
                    break;
                case 2: result = form.Num1 - form.Num2;
                    break;
                case 3: result = form.Num1 * form.Num2;
                    break;
                case 4: result = form.Num1 / form.Num2;
                    break;
                default: return Json(new { valid = false, result });
            }
            return Json(new { valid = true, result });
        }

        [HttpPost]
        public JsonResult Populate()
        {
            return Json(GetOperators());
        }

        public List<Operators> GetOperators()
        {
            using (var context = new CalculatorContext())
            {
                return context.Operators.ToList();
            }
        }
    }
}