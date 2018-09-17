using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class OrderValue
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }

        public ICollection<Order> Orders { get; set; }
        public OrderValue()
        {
            Orders = new List<Order>();
        }
    }
}
