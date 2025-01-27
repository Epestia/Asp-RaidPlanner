using Aeroport.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Raidplanner.Models.Forms;
using Raidplanner.Models;

namespace Raidplanner.Controllers
{
    public class RaidsController : Controller
    {
        private readonly DataContext _context;
        public RaidsController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Raids()
        {
            return View();
        }

        public IActionResult CreateRaids()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateRaidsForm model)
        {
            if (ModelState.IsValid)
            {
                _context.Raids.Add(new RaidsModel() { Name = model.Name, Date = model.Date, BossId = model.BossId, DJId = model.DJId });
                _context.SaveChanges();


                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
        public IActionResult AllRaids()
        {
            {
                var AllRaids = _context.Raids
                                    .Select(r => new CreateRaidsForm
                                    {
                                        Id = r.Id,
                                        Name = r.Name,
                                        Date = r.Date,
                                        BossId = r.BossId,
                                        DJId = r.DJId
                                    })
                                    .ToList();
                return View(AllRaids);
            }
        }
    }
}