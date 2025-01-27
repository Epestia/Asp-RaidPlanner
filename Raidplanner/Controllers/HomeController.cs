using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Raidplanner.Models;

namespace Raidplanner.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult Account()
    {
        return View();
    }
    public IActionResult SignIn()
    {
        return View();
    }
    public IActionResult Raids()
    {
        return View();
    }
}