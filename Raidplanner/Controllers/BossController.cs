using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Raidplanner.Models.Forms;
using Raidplanner.Models;
using Aeroport.Domain;
using Raidplanner.Services;

namespace Raidplanner.Controllers
{
    public class BossController : Controller
    {
        private readonly DataContext _context;
     

        public BossController(DataContext context)
        {
            _context = context;

        }
        public IActionResult Boss()
        {
            return View();
        }
        public IActionResult CreateBoss()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterBoss(CreateBossForm model)
        {
            if (ModelState.IsValid)
            {
                _context.Boss.Add(new BossModel() { Name = model.Name, Description = model.Description  }); ;
                _context.SaveChanges();


                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        public IActionResult AllBoss()
        {
            var AllBoss = _context.Boss
                                     .Select(Boss => new CreateBossForm
                                     {
                                         Name = Boss.Name,
                                         Description = Boss.Description,
                                     })
                                     .ToList();

            return View(AllBoss);
        }
    }
}

