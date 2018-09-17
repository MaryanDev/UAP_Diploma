using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string CustimerName { get; set; }
        public string CustormerPhone { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public bool IsCompleted { get; set; }
        public int OrderValueId { get; set; }
        public int OrderStateId { get; set; }
        public int FactoryId { get; set; }
        public int? EmployeeId { get; set; }

        [ForeignKey(nameof(OrderValueId))]
        public OrderValue OrderValue { get;set;}
        [ForeignKey(nameof(OrderStateId))]
        public OrderState OrderState { get; set; }
        [ForeignKey(nameof(FactoryId))]
        public Factory Factory { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }
    }
}
