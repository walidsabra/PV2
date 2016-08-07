using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductVisualizer.Models
{
    public class MarketSector
    {
        public int MarketSectorId { get; set; }
        [Display(Name = "Market Sector")]
        public string MarketSectorName { get; set; }
    }
}