﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EkipMobilya.Models;
using EkipMobilya.Areas.Admin.Models;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class KoleksiyonController : Controller
    {
        private ekipContext db = new ekipContext();
        // GET: Admin/Koleksiyon
        public ActionResult KoleksiyonIndex()
        {
            var koleksiyon = db.koleksiyon.ToList();
            return View(koleksiyon);
        }
        public ActionResult Create()
        {
            var koleksiyonView = new KoleksiyonView();
            koleksiyonView.koleksiyonModel = db.koleksiyon.ToList();
            koleksiyonView.koleksiyonBaslikModel = db.koleksiyonbaslik.ToList();
            return View(koleksiyonView);
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
            Koleksiyon koleksiyon = db.koleksiyon.Find(id);
            db.koleksiyon.Remove(koleksiyon);
            db.SaveChanges();
            return RedirectToAction("KoleksiyonIndex");
        }
    }
}