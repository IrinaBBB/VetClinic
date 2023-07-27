using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class AnimalConfig : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(150);
            builder.Property(p => p.DateOfBirth).HasColumnType("date");
            builder.Property(p => p.Neutered).HasDefaultValue(Neutered.Unknown);
            builder.Property(p => p.Chipped).HasDefaultValue(Chipped.Unknown);
            builder.Property(p => p.Sex).HasDefaultValue(Sex.Unknown);
            builder.Property(p => p.WeightInKilos).HasPrecision(precision: 6, scale: 2);
            builder.Property(p => p.EscapeAttempts).HasDefaultValue(0);
            builder.Property(p => p.DateRegistered).HasColumnType("date");
            builder.Property(p => p.DateUpdated).HasColumnType("date");
            builder.Property(p => p.SpeciesId).IsRequired().HasDefaultValue(1);
        }
    }
}
