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
        public DbSet<Owner> Owners => Set<Owner>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}