using System.ComponentModel.DataAnnotations;

namespace Raidplanner.Models.Forms
{
    public class CreateLootForm
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        [Range(1, int.MaxValue)]
        public int RaidId { get; set; }
        [Required]
        public IEnumerable<RaidsModel> Raids { get; set; } = Enumerable.Empty<RaidsModel>();
    }
}
