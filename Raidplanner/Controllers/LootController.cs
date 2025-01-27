using Aeroport.Domain;
using Microsoft.AspNetCore.Mvc;
using Raidplanner.Models.Forms;
using Raidplanner.Models;
using Raidplanner.Services;

namespace Raidplanner.Controllers
{
    public class LootController : Controller
    {
        private readonly DataContext _context;
        private readonly RaidsService _raidsService;
        private readonly LootService _lootService;

        public LootController(DataContext context, RaidsService raidsService, LootService lootService)
        {
            _context = context;
            _raidsService = raidsService;
            _lootService = lootService;
        }

        public IActionResult CreateLoot()
        {
            var model = new CreateLootForm
            {
                Raids = _raidsService.Get()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterLoot(CreateLootForm model)
        {
            if (ModelState.IsValid)
            {
                bool result = await _lootService.AddLootAsync(model);

                if (result)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Une erreur est survenue lors de l'ajout du loot.");
                }
            }

            model.Raids = _raidsService.Get();
            return View(model);
        }

        public async Task<IActionResult> AllLoot()
        {
            var allLoot = await _lootService.GetAllLootAsync();
            return View(allLoot);
        }
    }
}
