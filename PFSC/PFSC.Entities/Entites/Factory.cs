using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PFSC.Entities.Entites
{
    public class Factory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double? Longittude { get; set; }
        public double? Lattitude { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Address { get; set; }
        public string CountOfEmplyees { get; set; }
        public string SiteUrl { get; set; }
        public int DistrictId { get; set; }
        public bool IsApproved { get; set; }

        [ForeignKey(nameof(DistrictId))]
        public CityDistrict District { get; set; }
        public RegistrationRequest RegistrationRequest { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<FactoryToTechnology> Technologies { get; set; }
        public ICollection<FactoryToProduction> Production { get; set; }
        public ICollection<MachineToFactory> MachineModels { get; set; }
        public ICollection<FactoryWorkingHours> WorkingHours { get; set; }
        public ICollection<FactoryImage> FactoryImages { get; set; }

        public Factory()
        {
            Ratings = new List<Rating>();
            Reviews = new List<Review>();
            Technologies = new List<FactoryToTechnology>();
            MachineModels = new List<MachineToFactory>();
            WorkingHours = new List<FactoryWorkingHours>();
            Production = new List<FactoryToProduction>();
            FactoryImages = new List<FactoryImage>();
        }
    }
}
