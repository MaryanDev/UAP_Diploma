using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class RegistrationRequest
    {
        [Key]
        public int FactoryId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorPhone { get; set; }
        public string AuthorPosition { get; set; }
        public string AuthorEmail { get; set; }

        [ForeignKey(nameof(FactoryId))]
        public Factory Factory { get; set; }
    }
}
