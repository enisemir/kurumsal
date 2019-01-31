using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class KartController : Controller
    {
        // GET: Admin/Kart
        public ActionResult KartIndex()
        {
            return View();
        }
    }
}