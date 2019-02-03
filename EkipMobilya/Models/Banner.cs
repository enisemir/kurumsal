using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EkipMobilya.Models
{
    public class Banner
    {
        [Key]
        public int BannerId { get; set; }
        public string Baslik { get; set; }
        public string BannerFoto { get; set; }
    }
}