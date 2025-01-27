using System.ComponentModel.DataAnnotations;

namespace Raidplanner.Models.Forms
{
    public class CreateDjForm
    {
        [Required]
        public string Name { get; set; }
    }
}
