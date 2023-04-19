using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) {}
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<AnimalImage> AnimalImages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed.addData(modelBuilder);

            modelBuilder.Entity<Animal>()
                .Property(a => a.Sex)
                .HasDefaultValue(Sex.Unknown);  

            modelBuilder.Entity<Animal>()
                .Property(a => a.Chipped)
                .HasDefaultValue(Chipped.Unknown);

            modelBuilder.Entity<Animal>()
                .Property(a => a.Neutered)
                .HasDefaultValue(Neutered.Unknown);

            modelBuilder.Entity<Species>(entity =>
            {
                entity.HasMany(x => x.Animals)
                .WithOne(x => x.Species)
                .OnDelete(DeleteBehavior.SetNull);
            });
        }
    }
}
