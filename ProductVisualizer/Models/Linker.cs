using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductVisualizer.Models
{
    public class Linker
    {
        public int Id { get; set; }
         [Display(Name = "Software ID")]
        public int SoftwareId { get; set; }
        [Display(Name = "Object ID")]
        public int ObjectId { get; set; }
        [Display(Name = "Object Type")]
        public string ObjectType { get; set; }
        [Display(Name = "Assumptions/ Comments")]
        public string comments { get; set; }
    }
}