using System;
using System.Collections.Generic;
using System.Text;
using PFSC.Models.User;

namespace PFSC.Models.Factory
{
    public class RatingModel
    {
        public int Id { get; set; }
        public byte RankValue { get; set; }

        public User.UserModel UserModel { get; set; }
    }
}
