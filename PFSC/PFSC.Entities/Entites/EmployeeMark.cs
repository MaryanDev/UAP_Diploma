using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class EmployeeMark
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }
    }
}
