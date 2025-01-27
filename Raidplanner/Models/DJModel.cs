using System.ComponentModel.DataAnnotations;

namespace Raidplanner.Models
{
    public class DJModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RaidsModel> Raids { get; set; }


    }
}
