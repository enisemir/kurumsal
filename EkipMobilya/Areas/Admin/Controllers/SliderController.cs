using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EkipMobilya.Models;
using System.IO;
using System.Net;
using System.Data.Entity;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class SliderController : Controller
    {
        private ekipContext db = new ekipContext();
        // GET: Admin/Slider
        public ActionResult SliderIndex()
        {
            var slayt = db.slaytlar.ToList();            
            return View(slayt);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Slaytlar image)
        {
            string filename = Path.GetFileNameWithoutExtension(image.Imagefile.FileName);
            string extension = Path.GetExtension(image.Imagefile.FileName);
            filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
            image.Slaytfoto = "/Media/slider/" + filename;
            filename = Path.Combine(Server.MapPath("/Media/slider/"), filename);
            image.Imagefile.SaveAs(filename);
            db.slaytlar.Add(image);
            db.SaveChanges();
            ModelState.Clear();
            return View();
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Slaytlar slayt = db.slaytlar.Find(id);
            if (slayt == null)
            {
                return HttpNotFound();
            }
            return View(slayt);
        }
        [HttpPost]
        public ActionResult Edit(Slaytlar slayt)
        {
            if (ModelState.IsValid) { 
                string filename = Path.GetFileNameWithoutExtension(slayt.Imagefile.FileName);
                string extension = Path.GetExtension(slayt.Imagefile.FileName);
                filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                slayt.Slaytfoto = "/Media/slider/" + filename;
                filename = Path.Combine(Server.MapPath("/Media/slider/"), filename);
                slayt.Imagefile.SaveAs(filename);
                
                db.Entry(slayt).State = EntityState.Modified;
                db.SaveChanges();


                return RedirectToAction("SliderIndex");
            }
            return View(slayt);
        }

        public ActionResult Delete(int? id)
        {
            Slaytlar slayt = db.slaytlar.Find(id);
            db.slaytlar.Remove(slayt);
            db.SaveChanges();
            return RedirectToAction("SliderIndex");
        }
    }
}