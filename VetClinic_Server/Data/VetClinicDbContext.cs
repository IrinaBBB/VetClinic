using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using VetClinic_Server.Data.Models;

namespace VetClinic_Server.Data
{
    public class VetClinicDbContext : IdentityDbContext<AppUser>
    {
        public VetClinicDbContext(DbContextOptions<VetClinicDbContext> options) : base(options)
        {
        }

        public DbSet<Species> Species => Set<Species>();
        public DbSet<Pet> Pets => Set<Pet>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Species>().HasData(
                new Species { Id = 1, Name = "Cat" },
                new Species { Id = 2, Name = "Dog" },
                new Species { Id = 3, Name = "Fish" }
            );

            modelBuilder.Entity<Pet>().HasData(
                new Pet { Id = 1, Name = "Buddy", SpeciesId = 1, IsNeutered = true, Sex = Sex.Male },
                new Pet { Id = 2, Name = "Mittens", SpeciesId = 2, IsNeutered = true, Sex = Sex.Female },
                new Pet { Id = 3, Name = "Goldy", SpeciesId = 3, IsNeutered = false, Sex = Sex.Unknown }
            );
        }
    }
}