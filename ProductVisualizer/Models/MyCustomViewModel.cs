using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductVisualizer.Models
{
    public class MyCustomViewModel
    {
        public software Softwares { get; set; }
        public List<Phase> phases { get; set; }
        public List<discipline> disciplines { get; set; }
        public List<MarketSector> marketsectors { get; set; }
        public List<BIMUse> bimuses { get; set; }
        public List<GEO> geos { get; set; }
        public List<Task> tasks { get; set; }
        public List<Linker> comments { get; set; }
    }
}