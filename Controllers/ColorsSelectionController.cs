using SelectionDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SelectionDemo.Controllers
{
    public class ColorsSelectionController : Controller
    {
        public ActionResult Index()
        {
            return View(DB.ColorChoices.ToList());
        }

        public ActionResult Edit()
        {
            ViewBag.ColorChoices = SelectListUtilities<Color>.Convert(DB.ColorChoices.ToList(), "Caption");
            ViewBag.Colors = SelectListUtilities<Color>.Convert(DB.Colors.ToList(), "Caption");
            return View();
        }
        [HttpPost]
        public ActionResult Edit(List<int> ColorChoicesId)
        {
            DB.ColorChoices.Update(ColorChoicesId);
            return RedirectToAction("Index");
        }
    }
}