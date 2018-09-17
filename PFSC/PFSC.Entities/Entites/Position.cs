using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class Position
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<Employee> Employees { get; set; }

        public Position()
        {
            Employees = new List<Employee>();
        }
    }
}
