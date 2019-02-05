using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EkipMobilya.Models;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class KoleksiyonBaslikController : Controller
    {
        private ekipContext db = new ekipContext();
        // GET: Admin/KoleksiyonBaslik
        public ActionResult KoleksiyonBaslikIndex()
        {
            var koleksiyonbaslik = db.koleksiyonbaslik.ToList();
            return View(koleksiyonbaslik);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(KoleksiyonBaslik koleksiyonBaslik)
        {
            if (ModelState.IsValid)
            {
                db.koleksiyonbaslik.Add(koleksiyonBaslik);
                db.SaveChanges();
                return RedirectToAction("KoleksiyonBaslikIndex");
            }         
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
            KoleksiyonBaslik koleksiyonBaslik = db.koleksiyonbaslik.Find(id);
            db.koleksiyonbaslik.Remove(koleksiyonBaslik);
            db.SaveChanges();
            return RedirectToAction("KoleksiyonBaslikIndex");
        }
    }
}