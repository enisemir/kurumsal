﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EkipMobilya.Models;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class KartController : Controller
    {
        private Models.ekipContext db = new Models.ekipContext();
        // GET: Admin/Kart
        public ActionResult KartIndex()
        {
            var kart = db.kart.ToList();
            return View(kart);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int id)
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id)
        {
            return View();
        }

        public ActionResult Delete(int? id)
        {
            Kart kart = db.kart.Find(id);
            db.kart.Remove(kart);
            db.SaveChanges();
            return RedirectToAction("KartIndex");
        }
    }
}