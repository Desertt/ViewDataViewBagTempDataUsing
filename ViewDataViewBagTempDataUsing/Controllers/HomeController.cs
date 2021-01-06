﻿using System;
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
            return View();
        }
    }
}