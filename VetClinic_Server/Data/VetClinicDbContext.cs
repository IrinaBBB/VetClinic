using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using VetClinic_Server.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace VetClinic_Server.Data
{
    public class VetClinicDbContext : IdentityDbContext<AppUser>
    {
        public VetClinicDbContext(DbContextOptions<VetClinicDbContext> options) : base(options)
        {
        }

        public DbSet<Species> Species => Set<Species>();
        public DbSet<Pet> Pets => Set<Pet>();
        public DbSet<Vet> Vets => Set<Vet>();
        public DbSet<Specialization> Specializations => Set<Specialization>();
        public DbSet<TimeSlot> TimeSlots => Set<TimeSlot>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Species>().HasData(
                new Species { Id = 1, Name = "Cat" },
                new Species { Id = 2, Name = "Dog" },
                new Species { Id = 3, Name = "Fish" }
            );

            // SEED PETS
            modelBuilder.Entity<Pet>().HasData(
                new Pet { Id = 1, Name = "Buddy", SpeciesId = 1, IsNeutered = true, Sex = Sex.Male },
                new Pet { Id = 2, Name = "Mittens", SpeciesId = 2, IsNeutered = true, Sex = Sex.Female },
                new Pet { Id = 3, Name = "Goldy", SpeciesId = 3, IsNeutered = false, Sex = Sex.Unknown }
            );

            // SEED SPECIALIZATIONS
            modelBuilder.Entity<Specialization>().HasData(
                new Specialization { Id = 1, Name = "Veterinary Surgery", Description = "Specializes in performing surgical procedures on animals, including orthopedic, soft tissue, and minimally invasive surgeries." },
                new Specialization { Id = 2, Name = "Veterinary Dentistry", Description = "Specializes in dental care for animals, including oral surgery, cleanings, and treatments for dental diseases." },
                new Specialization { Id = 3, Name = "Small Animal Medicine and Surgery", Description = "Focuses on the diagnosis and treatment of diseases and injuries in pets like dogs and cats." },
                new Specialization { Id = 4, Name = "Exotic Animal Medicine", Description = "Focuses on the diagnosis and treatment of diseases and injuries in pets like dogs and cats." }
            );

            // SEED ROLES
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "2b51ab51-d0d9-44e1-a9e1-f0fab3563f00", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "38e1428b-c734-4130-830b-5bce7ab8ed38", Name = "Vet", NormalizedName = "VET" },
                new IdentityRole { Id = "f7e975ec-6546-4e14-809f-585f2446eae9", Name = "Owner", NormalizedName = "OWNER" }
            );
        }
    }
}