using Microsoft.EntityFrameworkCore;
using VetClinic.Entities;

namespace VetClinic.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Species> Species { get; set; }
        public DbSet<Animal> Animals { get; set; }
    }
}