
using System.ComponentModel.DataAnnotations;
namespace Raidplanner.Models.Forms
{
    public class CreateRaidsForm
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Date { get; set; }
   
        public int BossId { get; set; }

        public int DJId { get; set; }
    }
}
