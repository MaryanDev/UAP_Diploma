using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFSC.Entities.Entites
{
    public class Employee
    {             
        [Key]
        public int Id { get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PositionId { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set;}
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Salary { get; set; }
        public int FactoryId { get; set; }
        public string AvatarPath { get; set; }

        [ForeignKey(nameof(FactoryId))]
        public Factory Factory { get; set; }
        [ForeignKey(nameof(PositionId))]
        public Position Position { get; set; }
        public ICollection<EmployeeMark> EmployeeMarks { get; set; }
        public ICollection<Order> Orders { get; set; }

        public Employee()
        {
            EmployeeMarks = new List<EmployeeMark>();
            Orders = new List<Order>();
        }
    }
}
