using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductVisualizer.Models
{
    public class BIMUse
    {
        public int BIMUseId { get; set; }
        [Display(Name = "BIMUse")]
        public string BIMUseName { get; set; }

        public virtual List<Task> Tasks { get; set; }
    }
}