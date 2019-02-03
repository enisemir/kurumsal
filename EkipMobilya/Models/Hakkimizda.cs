using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EkipMobilya.Models
{
    public class Hakkimizda
    {
        [Key]
        public int HakkimizdaId { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string UstGorsel { get; set; }
        public string AltGorsel { get; set; }
    }
}