using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class OwnerConfig : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(150);
            builder.Property(p => p.Email).IsRequired().HasMaxLength(250);
        }
    }
}
