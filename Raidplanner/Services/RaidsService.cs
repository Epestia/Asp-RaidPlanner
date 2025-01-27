using Raidplanner.Models.Forms;
using Raidplanner.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System;
using Aeroport.Domain;

namespace Raidplanner.Services
{
    public class RaidsService
    {
        private readonly DataContext _context;

        public RaidsService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<RaidsModel> Get()
        {
            return _context.Raids;
        }

        public async  Task<RaidsModel?> GetRaidById(int id)
        {
            return await _context.Raids.FirstOrDefaultAsync(r => r.Id == id);
        }

      
    }
}
