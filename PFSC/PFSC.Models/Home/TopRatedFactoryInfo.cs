using System;
using System.Collections.Generic;
using System.Text;

namespace PFSC.Models.Home
{
    public class TopRatedFactoryInfo
    {
        public int FactoryId { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public double AverageRate { get; set; }
    }
}
