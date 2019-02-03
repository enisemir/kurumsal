using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EkipMobilya.Models
{
    public class KoleksiyonBaslik
    {
        [Key]
        public int KoleksiyonBaslikId { get; set; }
        public string KoleksiyonBaslikIsim { get; set; }

        public List<Koleksiyon> Koleksiyonlar { get; set; }
    }
}