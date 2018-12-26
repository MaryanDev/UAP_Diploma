using System;
using System.Collections.Generic;
using System.Text;
using PFSC.Models.User;

namespace PFSC.Models.Factory
{
    public class ReviewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime DateCreated { get; set; }
        public UserModel User { get; set; }

        public string ReviewResultTitle { get; set; }
        public string ReviewResultDescription { get; set; }
    }
}
