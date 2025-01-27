using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Raidplanner.Models
{
    public class DJConfiguration : IEntityTypeConfiguration<DJModel>
    {
        public void Configure(EntityTypeBuilder<DJModel> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasMany(d => d.Raids)
                   .WithOne(r => r.DJ)
                   .HasForeignKey(r => r.DJId);
        }
    }
}
