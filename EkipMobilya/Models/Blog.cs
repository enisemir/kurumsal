using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EkipMobilya.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string Resim { get; set; }
    }
}