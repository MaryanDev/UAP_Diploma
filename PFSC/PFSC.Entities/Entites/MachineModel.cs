using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class MachineModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ManufacturerId { get; set; }

        [ForeignKey(nameof(ManufacturerId))]
        public MachineManufacturer Manufacturer { get; set; }
        public ICollection<MachineToFactory> Factories { get; set; }

        public MachineModel()
        {
            Factories = new List<MachineToFactory>();
        }
    }
}
