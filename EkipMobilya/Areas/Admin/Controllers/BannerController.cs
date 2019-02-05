using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class BannerController : Controller
    {
        private Models.ekipContext db = new Models.ekipContext();
        // GET: Admin/Banner
        public ActionResult BannerIndex()
        {
            var banner = db.banner.ToList();
            return View(banner);
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