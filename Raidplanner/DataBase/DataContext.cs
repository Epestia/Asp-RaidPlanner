
using Microsoft.EntityFrameworkCore;
using Raidplanner.Models;

namespace Aeroport.Domain
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<BossModel> Boss { get; set; }

        public DbSet<DJModel> DJ { get; set; }

        public DbSet<LootModel> Loot { get; set; }

        public DbSet<RaidsModel> Raids { get; set; }

        public DbSet<UserModel> User { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);


        }

    }
}
