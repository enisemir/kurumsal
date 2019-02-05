using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EkipMobilya.Models;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class AnaKategorilerController : Controller
    {
        private ekipContext db = new ekipContext();
        // GET: Admin/AnaKategoriler
        public ActionResult AnaKategorilerIndex()
        {
            var anakategoriler = db.anakategoriler.ToList();
            return View(anakategoriler);
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

        public ActionResult Delete()
        {
            AnaKategoriler anaKategoriler = db.anakategoriler.Find(id);
            db.anakategoriler.Remove(anaKategoriler);
            db.SaveChanges();
            return RedirectToAction("AnaKategorilerIndex");
        }
    }
}