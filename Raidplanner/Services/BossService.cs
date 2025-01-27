using Aeroport.Domain;
using Raidplanner.Models;
using Raidplanner.Models.Forms;

namespace Raidplanner.Services
{
    public class BossService
    {
        private readonly DataContext _context;

        public BossService(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> AddBossAsync(CreateBossForm model)
        {
            if (model == null)
                return false;

            try
            {
                var loot = new LootModel
                {
                    Name = model.Name,
                    Description = model.Description,
                };


                _context.Loot.Add(loot);
                await _context.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}