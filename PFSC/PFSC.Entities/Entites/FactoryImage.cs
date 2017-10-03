using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class FactoryImage
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public int FactoryId { get; set; }

        [ForeignKey(nameof(FactoryId))]
        public Factory Factory { get; set; }
    }
}
