using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class KoleksiyonController : Controller
    {
        // GET: Admin/Koleksiyon
        public ActionResult KoleksiyonIndex()
        {
            return View();
        }
    }
}