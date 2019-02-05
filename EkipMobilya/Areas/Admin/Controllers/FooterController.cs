using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EkipMobilya.Models;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class FooterController : Controller
    {
        private Models.ekipContext db = new ekipContext();
        // GET: Admin/Footer
        public ActionResult FooterIndex()
        {
            var footer = db.footer.ToList();
            return View(footer);
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
            Footer footerr = db.footer.Find(id);
            db.footer.Remove(footerr);
            db.SaveChanges();
            return RedirectToAction("FooterIndex");
        }
    }
}