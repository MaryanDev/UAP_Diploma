using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class MachineToFactory
    {
        public int Id { get; set; }
        public int MachineId { get; set; }
        public int FactoryId { get; set; }

        [ForeignKey(nameof(MachineId))]
        public MachineModel Machine { get; set; }
        [ForeignKey(nameof(FactoryId))]
        public Factory Factory { get; set; }
    }
}
