using System.ComponentModel.DataAnnotations;

namespace Raidplanner.Models
{
    public class BossModel
    {
       
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
     
        public virtual ICollection<RaidsModel> Raids { get; set; }

    }
}
