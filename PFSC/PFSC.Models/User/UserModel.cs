using PFSC.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace PFSC.Models.User
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AvatarPath { get; set; }
        public PfscRoles Role { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
