using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EkipMobilya.Models
{
    public class Galeri
    {
        [Key]
        public int GaleriId { get; set; }
        public string Resim { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }

        
        public int AnaKategorilerId { get; set; }
        [ForeignKey("AnaKategorilerId")]
        public AnaKategoriler anaKategorilers { get; set; }
    }
}