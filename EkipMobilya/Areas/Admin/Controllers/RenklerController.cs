using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class RenklerController : Controller
    {
        // GET: Admin/Renkler
        public ActionResult RenklerIndex()
        {
            return View();
        }
    }
}