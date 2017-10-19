using System;
using System.Collections.Generic;
using System.Text;
using PFSC.Models.Common;

namespace PFSC.Models.Search
{
    public class SearchFactoryModel : FactoryShortModel
    {
        public string Description { get; set; }
        public double Rating { get; set; }
        public Location Location { get; set; }
    }
}
