using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EkipMobilya.Models;

namespace EkipMobilya.Areas.Admin.Models
{
    public class KoleksiyonView
    {
        public List<Koleksiyon> koleksiyonModel { get; set; }
        public List<KoleksiyonBaslik> koleksiyonBaslikModel { get; set; }
    }
}