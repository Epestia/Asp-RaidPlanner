using Aeroport.Domain;
using Microsoft.AspNetCore.Mvc;
using Raidplanner.Models;
using Raidplanner.Models.Forms;

namespace Raidplanner.Controllers
{
    public class UserController : Controller
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(CreateUserForm model)
        {
            if (ModelState.IsValid)
            {
                _context.User.Add(new UserModel() { Name = model.Name, Email = model.Email, Password = model.Password});
                _context.SaveChanges();

 
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
    }
}
