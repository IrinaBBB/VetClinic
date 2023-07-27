using System.Reflection;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) {}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed.AddData(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<AnimalImage> AnimalImages { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Vet> Vets { get; set; }
        public DbSet<Visit> Visits { get; set; }
    }
}
