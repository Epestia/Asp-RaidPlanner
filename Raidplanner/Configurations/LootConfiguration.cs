using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Raidplanner.Models
{
    public class LootConfiguration : IEntityTypeConfiguration<LootModel>
    {
        public void Configure(EntityTypeBuilder<LootModel> builder)
        {
            builder.HasKey(l => l.Id);

            builder.Property(l => l.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(l => l.Description)
                   .HasMaxLength(500);

            builder.HasOne(l => l.Raid)
                   .WithMany(r => r.Loots)
                   .HasForeignKey(l => l.RaidId);
        }
    }
}
