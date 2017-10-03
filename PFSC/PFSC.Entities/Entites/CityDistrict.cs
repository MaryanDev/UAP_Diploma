using System;
using System.Collections.Generic;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class CityDistrict
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<Factory> Factories { get; set; }

        public CityDistrict()
        {
            Factories = new List<Factory>();
        }
    }
}
