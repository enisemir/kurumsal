using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EkipMobilya.Models
{
    public class Slaytlar
    {
        [Key]
        public int SlaytId { get; set; }
        public int Slaytfoto { get; set; }
    }
}