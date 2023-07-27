using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class SpeciesConfig : IEntityTypeConfiguration<Species>
    {
        public void Configure(EntityTypeBuilder<Species> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(250);
            builder.Property(p => p.Description).HasMaxLength(500);
        }
    }
}
