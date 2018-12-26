using System;
using System.Collections.Generic;
using System.Text;

namespace PFSC.Models.Factory
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustormerPhone { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public bool IsCompleted { get; set; }
        public string OrderValue { get; set; }
        public string OrderState { get; set; }
        public EmployeeModel Employee { get; set; }
    }
}
