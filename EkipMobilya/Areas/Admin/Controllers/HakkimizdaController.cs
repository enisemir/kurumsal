using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EkipMobilya.Areas.Admin.Controllers
{
    public class HakkimizdaController : Controller
    {
        // GET: Admin/Hakkimizda
        public ActionResult HakkimizdaIndex()
        {
            return View();
        }
    }
}