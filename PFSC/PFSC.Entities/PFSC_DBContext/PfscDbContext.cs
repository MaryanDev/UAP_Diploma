using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PFSC.Entities.Entites;

namespace PFSC.Entities.PFSC_DBContext
{
    public class PfscDbContext : DbContext
    {
        public PfscDbContext(DbContextOptions<PfscDbContext> options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CityDistrict> CityDistricts { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<FactoryImage> FactoryImages { get; set; }
        public DbSet<MachineManufacturer> MachineManufacturers { get; set; }
        public DbSet<MachineModel> MachineModels { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ReviewResult> ReviewResults { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
