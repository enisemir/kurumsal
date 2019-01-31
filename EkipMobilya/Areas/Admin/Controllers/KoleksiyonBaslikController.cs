using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class KoleksiyonBaslikController : Controller
    {
        // GET: Admin/KoleksiyonBaslik
        public ActionResult KoleksiyonBaslikIndex()
        {
            return View();
        }
    }
}