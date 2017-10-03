using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class FactoryToCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int FactoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
        [ForeignKey(nameof(FactoryId))]
        public Factory Factory { get; set; }
    }
}
