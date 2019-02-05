using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EkipMobilya.Models;
using System.IO;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class RenklerController : Controller
    {
        private ekipContext db = new ekipContext();
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
        public ActionResult Create(Renkler image)
        {
            string filename = Path.GetFileNameWithoutExtension(image.Imagefile.FileName);
            string extension = Path.GetExtension(image.Imagefile.FileName);
            filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
            image.RenkResim = "/Media/renk/" + filename;
            filename = Path.Combine(Server.MapPath("/Media/renk/"), filename);
            image.Imagefile.SaveAs(filename);
            db.renkler.Add(image);
            db.SaveChanges();
            ModelState.Clear();
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