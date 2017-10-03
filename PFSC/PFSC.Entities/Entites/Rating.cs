using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class Rating
    {
        public int Id { get; set; }
        public byte RankValue { get; set; }
        public int UserId { get; set; }
        public int FactoryId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        [ForeignKey(nameof(FactoryId))]
        public Factory Factory { get; set; }
    }
}
