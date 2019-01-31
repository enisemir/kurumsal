using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class BannerController : Controller
    {
        // GET: Admin/Banner
        public ActionResult BannerIndex()
        {
            return View();
        }
    }
}