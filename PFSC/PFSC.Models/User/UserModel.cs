﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PFSC.Models.User
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AvatarPath { get; set; }
    }
}
