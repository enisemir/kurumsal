using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EkipMobilya.Models
{
    public class DetayIcerik
    {
        [Key]
        public int DetayIcerikId { get; set; }
        public string Icerik { get; set; }
    }
}