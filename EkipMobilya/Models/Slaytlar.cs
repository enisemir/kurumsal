using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EkipMobilya.Models
{
    public class Slaytlar
    {
        [Key]
        public int SlaytId { get; set; }
        [DisplayName("Slayt Resim")]
        public string Slaytfoto { get; set; }

        [NotMapped]
        public HttpPostedFileBase Imagefile { get; set; }

    }
}