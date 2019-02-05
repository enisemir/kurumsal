using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class KoleksiyonBaslikController : Controller
    {
        private Models.ekipContext db = new Models.ekipContext();
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
            return View();
        }
    }
}