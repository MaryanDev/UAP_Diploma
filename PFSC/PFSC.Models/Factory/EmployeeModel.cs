using System;
using System.Collections.Generic;
using System.Text;

namespace PFSC.Models.Factory
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string AvatarPath { get; set; }
        public decimal Salary { get; set; }
    }
}
