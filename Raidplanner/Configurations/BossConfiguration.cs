using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Raidplanner.Models;

namespace Raidplanner.Configurations
{
    public class BossConfiguration : IEntityTypeConfiguration<BossModel>
    {
        public void Configure(EntityTypeBuilder<BossModel> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(b => b.Description)
                   .HasMaxLength(500);

            builder.HasMany(b => b.Raids)
                   .WithOne(r => r.Boss)
                   .HasForeignKey(r => r.BossId);
        }
    }
}
