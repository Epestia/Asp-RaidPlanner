using Raidplanner.Models;

namespace Raidplanner.Entities
{
    public class LootEntities
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int RaidId { get; set; }


        public virtual RaidsModel Raid { get; set; }
    }
}
