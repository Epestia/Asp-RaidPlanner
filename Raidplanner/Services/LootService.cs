using Raidplanner.Models.Forms;
using Raidplanner.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using Aeroport.Domain;

namespace Raidplanner.Services
{
    public class LootService
    {
        private readonly DataContext _context;

        public LootService(DataContext context)
        {
            _context = context;
        }

   
        public async Task<bool> AddLootAsync(CreateLootForm model)
        {
            if (model == null || model.RaidId == 0)
                return false;

            try
            {
                var loot = new LootModel
                {
                    Name = model.Name,
                    Description = model.Description,
                    RaidId = model.RaidId 
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
        public async Task<List<CreateLootForm>> GetAllLootAsync()
        {
            return await _context.Loot
                .Select(loot => new CreateLootForm
                {
                    Name = loot.Name,
                    Description = loot.Description,
                    RaidId = loot.RaidId,
                })
                .ToListAsync();
        }
    }
}
