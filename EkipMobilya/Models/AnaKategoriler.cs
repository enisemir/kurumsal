using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EkipMobilya.Models
{
    public class AnaKategoriler
    {
        [Key]
        public int AnaKategorilerId { get; set; }
        public string Baslik { get; set; }

        public List<Galeri> Galeriler { get; set; }
    }
}