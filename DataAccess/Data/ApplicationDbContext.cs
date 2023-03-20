using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) {}
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Species> Species { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .Property(a => a.Sex)
                .HasDefaultValue(Sex.Unknown);  

            modelBuilder.Entity<Animal>()
                .Property(a => a.Chipped)
                .HasDefaultValue(Chipped.Unknown);

            modelBuilder.Entity<Animal>()
                .Property(a => a.Neutered)
                .HasDefaultValue(Neutered.Unknown);
        }
    }
}
