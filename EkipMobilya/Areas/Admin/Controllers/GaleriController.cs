using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EkipMobilya.Models;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class GaleriController : Controller
    {
        private Models.ekipContext db = new ekipContext();
        // GET: Admin/Galeri
        public ActionResult GaleriIndex()
        {
            var galeri = db.galeri.ToList();
            return View(galeri);
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
            Galeri gaLeri = db.galeri.Find(id);
            db.galeri.Remove(gaLeri);
            db.SaveChanges();
            return RedirectToAction("GaleriIndex");
        }
    }
}