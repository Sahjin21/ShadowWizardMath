using Microsoft.AspNetCore.Mvc;
using ShadowWizardMath.Models;
using System.Diagnostics;

namespace ShadowWizardMath.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult LevelView()
        {
            var level = new Level();
            level.Stage = 1;

            // Create enemy objects
            var goblin1 = new Goblin("Goblin 1", "A small green creature.", 100, 1, 10, 3);
            var goblin2 = new Goblin("Goblin 2", "Another small green creature.", 100, 1, 10, 3);

            // Add enemies to the level's Enemies list
            level.Enemies.Add(goblin1);
            level.Enemies.Add(goblin2);

            // Pass the Level object to the view
            return View(level);
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
    }
}