using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AvatarPath { get; set; }
        public int RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Review> Reviews { get; set; }

        public User()
        {
            Ratings = new List<Rating>();
            Reviews = new List<Review>();
        }
    }
}
