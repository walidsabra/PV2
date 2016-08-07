using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductVisualizer.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public int BIMUseId { get; set; }
        [Display(Name = "Task/activity")]
        public string TaskName { get; set; }
    }
}