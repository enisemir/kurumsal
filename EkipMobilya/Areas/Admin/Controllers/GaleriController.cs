using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class GaleriController : Controller
    {
        // GET: Admin/Galeri
        public ActionResult GaleriIndex()
        {
            return View();
        }
    }
}