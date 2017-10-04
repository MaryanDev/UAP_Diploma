using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class FactoryToProduction
    {
        public int Id { get; set; }
        public int FactoryId { get; set; }
        public int PrintingProductionId { get; set; }

        [ForeignKey(nameof(FactoryId))]
        public Factory Factory { get; set; }
        [ForeignKey(nameof(PrintingProductionId))]
        public PrintingProduction Production { get; set; }
    }
}
