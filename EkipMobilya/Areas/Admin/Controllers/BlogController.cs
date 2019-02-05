using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EkipMobilya.Models;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class BlogController : Controller
    {
        private ekipContext db = new ekipContext();
        // GET: Admin/Blog
        public ActionResult BlogIndex()
        {
            var blog = db.blog.ToList();
            return View(blog);
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
            Blog bLog = db.blog.Find(id);
            db.blog.Remove(bLog);
            db.SaveChanges();
            return RedirectToAction("BlogIndex");
        }
    }
}