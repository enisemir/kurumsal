using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EkipMobilya.Models
{
    public class Kart
    {
        [Key]
        public int KartId { get; set; }
        public string KartImage { get; set; }
        public string KartBaslik { get; set; }
    }
}