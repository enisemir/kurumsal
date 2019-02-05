using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EkipMobilya.Models
{
    public class Renkler
    {
        [Key]
        public int RenklerId { get; set; }
        public string RenkResim { get; set; }
        public string RenkAdi { get; set; }

        [NotMapped]
        public HttpPostedFileBase Imagefile { get; set; }
    }
}