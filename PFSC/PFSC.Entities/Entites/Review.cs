using System;
using System.Collections.Generic;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FactoryId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime DateCreated { get; set; }
        public int ReviewResultId { get; set; }

        public User User { get; set; }
        public Factory Factory { get; set; }
        public ReviewResult ReviewResult { get; set; }
    }
}
