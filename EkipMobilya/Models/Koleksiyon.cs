using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EkipMobilya.Models
{
    public class Koleksiyon
    {
        [Key]
        public int KoleksiyonId { get; set; }
        public string KoleksiyonResim { get; set; }
        public string KoleksiyonIcerik { get; set; }
        public string KoleksiyonAdi { get; set; }
        [NotMapped]
        public HttpPostedFileBase Imagefile { get; set; }


        public int KoleksiyonBaslikId { get; set; }
        [ForeignKey("KoleksiyonBaslikId")]
        public KoleksiyonBaslik koleksiyonBaslik { get; set; }
    }
}