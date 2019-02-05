using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EkipMobilya.Models;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class HakkimizdaController : Controller
    {
        private Models.ekipContext db = new ekipContext();
        // GET: Admin/Hakkimizda
        public ActionResult HakkimizdaIndex()
        {
            var hakkimizda = db.hakkimizda.ToList();
            return View(hakkimizda);
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
            Hakkimizda hakkimizDa = db.hakkimizda.Find(id);
            db.hakkimizda.Remove(hakkimizDa);
            db.SaveChanges();
            return RedirectToAction("HakkimizdaIndex");
        }
    }
}