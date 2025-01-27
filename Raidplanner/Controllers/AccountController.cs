
using Aeroport.Domain;
using Microsoft.AspNetCore.Mvc;
using Raidplanner.Models;
using System.Linq;

namespace Raidplanner.Controllers
{
    public class AccountController : Controller
    {
        private readonly DataContext _context;

        public AccountController(DataContext context)
        {
            _context = context;
        }

        // Afficher le formulaire de login
        public IActionResult Login()
        {
            return View();
        }

        // Traiter les informations du formulaire de login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                var user = _context.User.FirstOrDefault(u => u.Email == userModel.Email && u.Password == userModel.Password);

                if (user != null)
                {
                    // Utilisateur trouvé, connecter l'utilisateur (par exemple avec un cookie ou un jeton)
                    // Par exemple, on peut utiliser les sessions ou une authentification avec ASP.NET Core Identity
                    TempData["Message"] = "Login successful!";
                    return RedirectToAction("Index", "Home"); // Rediriger vers la page d'accueil
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login attempt.");
                }
            }
            return View(userModel);
        }

        // Déconnexion
        public IActionResult Logout()
        {
            // Logique pour déconnecter l'utilisateur (par exemple, supprimer le cookie/session)
            TempData["Message"] = "Logged out successfully!";
            return RedirectToAction("Login");
        }
    }
}
