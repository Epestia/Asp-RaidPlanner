using Raidplanner.Models;

namespace Raidplanner.Entities
{
    public class DjEntities
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RaidsModel> Raids { get; set; }
    }
}
