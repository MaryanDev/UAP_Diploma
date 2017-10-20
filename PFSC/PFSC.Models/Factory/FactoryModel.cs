using System;
using System.Collections.Generic;
using System.Text;
using PFSC.Models.Search;

namespace PFSC.Models.Factory
{
    public class FactoryModel : SearchFactoryModel
    {
        public DateTime? DateCreated { get; set; }
        public string CountOfEmployees { get; set; }
        public string SiteUrl { get; set; }
        public string District { get; set; }
        public IEnumerable<string> FactoryImages { get; set; }
        public IEnumerable<RatingModel> Ratings { get; set; }
        public IEnumerable<ReviewModel> Reviews { get; set; }
        public IEnumerable<CriteriaModel> Technologies { get; set; }
        public IEnumerable<CriteriaModel> Production { get; set; }
        public IEnumerable<MachineModel> Machines { get; set; }
        public IEnumerable<WorkingHoursModel> WorkingHours { get; set; }
    }
}
