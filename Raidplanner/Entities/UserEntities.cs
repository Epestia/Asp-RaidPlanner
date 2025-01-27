using Raidplanner.Models;

namespace Raidplanner.Entities
{
    public class UserEntities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<RaidsModel> Raids { get; set; }
    }
}
