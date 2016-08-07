using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductVisualizer.Models
{
    public class Phase
    {
        public int PhaseId { get; set; }
         [Display(Name = "Phase")]
        public string PhaseName { get; set; }
    }
}