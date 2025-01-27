using Aeroport.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Raidplanner.Models.Forms;
using Raidplanner.Models;

namespace Raidplanner.Controllers
{
    public class DjController : Controller
    {
        private readonly DataContext _context;
        public DjController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Donjon()
        {
            return View();
        }

        public IActionResult CreateDj()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterDj(CreateDjForm model)
        {
            if (ModelState.IsValid)
            {
                _context.DJ.Add(new DJModel() { Name = model.Name }); ;
                _context.SaveChanges();


                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        public IActionResult AllDonjon()
        {
            var AllDonjons = _context.DJ
                                     .Select(dj => new CreateDjForm
                                     {
                                         Name = dj.Name,
                                     })
                                     .ToList();

            return View(AllDonjons);
        }


    }
}
