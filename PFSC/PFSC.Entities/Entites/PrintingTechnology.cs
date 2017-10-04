using System;
using System.Collections.Generic;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class PrintingTechnology
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<FactoryToTechnology> Factories { get; set; }

        public PrintingTechnology()
        {
            Factories = new List<FactoryToTechnology>();
        }
    }
}
