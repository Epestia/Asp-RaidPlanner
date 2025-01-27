using Raidplanner.Models;

namespace Raidplanner.Entities
{
    public class RaidEntities
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public int BossId { get; set; }

        public int DJId { get; set; }


        public virtual BossModel Boss { get; set; }
        public virtual DJModel DJ { get; set; }
        public virtual ICollection<UserModel> Users { get; set; }
        public virtual ICollection<LootModel> Loots { get; set; }
    }
}
