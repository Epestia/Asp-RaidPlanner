using System.ComponentModel.DataAnnotations;

namespace Raidplanner.Models.Forms
{
    public class CreateBossForm
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

    }
}
