using System;
using System.Collections.Generic;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class Role
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<User> Users { get; set; }

        public Role()
        {
            Users = new List<User>();
        }
    }
}
