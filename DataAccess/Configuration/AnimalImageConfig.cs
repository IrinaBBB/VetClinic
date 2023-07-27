using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class AnimalImageConfig : IEntityTypeConfiguration<AnimalImage>
    {
        public void Configure(EntityTypeBuilder<AnimalImage> builder)
        {
            builder.Property(p => p.AnimalImageUrl).HasMaxLength(500).IsUnicode(false);
        }
    }
}