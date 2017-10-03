using System;
using System.Collections.Generic;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class ReviewResult
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ReviewResult()
        {
            Reviews = new List<Review>();
        }
    }
}
