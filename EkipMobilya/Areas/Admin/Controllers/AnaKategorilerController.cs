﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class AnaKategorilerController : Controller
    {
        // GET: Admin/AnaKategoriler
        public ActionResult AnaKategorilerIndex()
        {
            return View();
        }
    }
}