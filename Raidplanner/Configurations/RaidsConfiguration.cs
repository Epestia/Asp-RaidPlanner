using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Raidplanner.Models;

namespace Raidplanner.Configurations
{
    public class RaidsConfiguration : IEntityTypeConfiguration<RaidsModel>
    {
        public void Configure(EntityTypeBuilder<RaidsModel> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Name).IsRequired().HasMaxLength(200);
            builder.Property(r => r.Date).IsRequired();

            builder.HasOne(r => r.Boss)
                .WithMany(b => b.Raids)
                .HasForeignKey(r => r.BossId);

            builder.HasOne(r => r.DJ)
                .WithMany(d => d.Raids)
                .HasForeignKey(r => r.DJId);

            builder.HasMany(r => r.Users)
                .WithMany(u => u.Raids)
                .UsingEntity<Dictionary<string, object>>(
                    "UserRaid",
                    j => j.HasOne<UserModel>().WithMany().HasForeignKey("UserId"),
                    j => j.HasOne<RaidsModel>().WithMany().HasForeignKey("RaidId")
                );

            builder.HasMany(r => r.Loots)
                .WithOne(l => l.Raid)
                .HasForeignKey(l => l.RaidId);
        }
    }
}
