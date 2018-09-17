using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class OrderState
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
        public ICollection<Order> Orders { get; set; }
        public OrderState()
        {
            Orders = new List<Order>();
        }
    }
}
