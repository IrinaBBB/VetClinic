using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class VisitConfig : IEntityTypeConfiguration<Visit>
    {
        public void Configure(EntityTypeBuilder<Visit> builder)
        {
            builder.Property(p => p.VisitDateTime).IsRequired().HasColumnType("datetime");
        }
    }
}
