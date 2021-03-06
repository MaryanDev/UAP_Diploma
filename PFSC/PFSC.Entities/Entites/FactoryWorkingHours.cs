﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class FactoryWorkingHours
    {
        public int Id { get; set; }
        public int FactoryId { get; set; }
        public byte DayOfWeek { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }

        [ForeignKey(nameof(FactoryId))]
        public Factory Factory { get; set; }
    }
}
