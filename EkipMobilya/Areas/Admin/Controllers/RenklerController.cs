﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EkipMobilya.Models;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class RenklerController : Controller
    {
        private Models.ekipContext db = new Models.ekipContext();
        // GET: Admin/Renkler
        public ActionResult RenklerIndex()
        {
            var renkler = db.renkler.ToList();
            return View(renkler);
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
            Renkler renk = db.renkler.Find(id);
            db.renkler.Remove(renk);
            db.SaveChanges();
            return RedirectToAction("RenklerIndex");
        }
    }
}