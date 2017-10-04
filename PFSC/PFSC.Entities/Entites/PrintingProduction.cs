using System;
using System.Collections.Generic;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class PrintingProduction
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<FactoryToProduction> Factories { get; set; }

        public PrintingProduction()
        {
            Factories = new List<FactoryToProduction>();
        }
    }
}
