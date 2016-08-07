using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductVisualizer.Models
{
    public class discipline
    {
        public int DisciplineId { get; set; }
        [Display(Name = "Discipline")]
        public string DisciplineName { get; set; }
    }
}