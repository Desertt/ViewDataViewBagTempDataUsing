using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewDataViewBagTempDataUsing.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Ad"] = "Mustafa DAĞTEKİN";
            ViewBag.Adi = "Kazım Miraç DAĞTEKİN";
            TempData["Ad"] = "Merve DAĞTEKİN";
            return RedirectToAction("Ornek");
        }

        public ActionResult Ornek()
        {
            var ViewDataVeri = ViewData["Ad"];
            if (ViewDataVeri==null)
            {
                ViewData["Ad"] = "Bu Controllerdan Veri Gelmemiştir. ";
            }
            var ViewBagVeri = ViewBag.Adi;
            if (ViewBagVeri == null)
            {
                ViewBag.Adi= "Bu Controllerdan Veri Gelmemiştir. ";
            }
            var TempDataVeri = TempData["Ad"];
            if (TempDataVeri == null)
            {
                TempData["Ad"] = "Bu Controllerdan Veri Gelmemiştir. ";
            }
            return View();
        }
    }
}