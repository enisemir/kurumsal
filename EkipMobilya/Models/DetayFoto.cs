﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EkipMobilya.Models
{
    public class DetayFoto
    {
        [Key]
        public int DetayFotoId { get; set; }
        public string DetayResim { get; set; }
    }
}