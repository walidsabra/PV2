using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductVisualizer.Models
{
    public class GEO
    {
        public int GEOId { get; set; }
         [Display(Name = "GEO")]
        public string GEOName { get; set; }
    }
}