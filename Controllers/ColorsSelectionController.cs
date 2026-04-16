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
            return View(DB.SelectedColors.ToList());
        }

        public ActionResult Edit()
        {
            ViewBag.SelectedColors = SelectListUtilities<Color>.Convert(DB.SelectedColors.ToList(), "Caption");
            ViewBag.AllColors = SelectListUtilities<Color>.Convert(DB.AllColors.ToList(), "Caption");
            return View();
        }
        [HttpPost]
        public ActionResult Edit(List<int> selectedColorsId)
        {
            DB.SelectedColors.Update(selectedColorsId);
            return RedirectToAction("Index");
        }
    }
}