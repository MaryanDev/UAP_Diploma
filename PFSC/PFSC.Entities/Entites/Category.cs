using System;
using System.Collections.Generic;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<FactoryToCategory> Factories { get; set; }

        public Category()
        {
            Factories = new List<FactoryToCategory>();
        }
    }
}
