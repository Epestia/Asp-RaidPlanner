using Raidplanner.Models;

namespace Raidplanner.Entities
{
    public class BossEntities
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<RaidsModel> Raids { get; set; }
    }
}
