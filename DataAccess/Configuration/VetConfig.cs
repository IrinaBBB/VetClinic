using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class VetConfig : IEntityTypeConfiguration<Vet>
    {
        public void Configure(EntityTypeBuilder<Vet> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(150);
            builder.Property(p => p.DateOfGraduation).HasColumnType("date");
        }
    }
}
