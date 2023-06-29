using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShadowWizardMath.Models;
using System.Diagnostics;
using System.Reflection;
using System.Resources;

namespace ShadowWizardMath.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult LevelView(string playerName)
        {
            var level = new Level();
            level.Stage = 1;
            System.Diagnostics.Debug.WriteLine("Current level: " + level.Stage);

            // Deserialize enemy data json file
            string jsonFilePath = "wwwroot/json/enemies.json";
            string jsonString = System.IO.File.ReadAllText(jsonFilePath);
            var json = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, List<Enemy>>>(jsonString);
            var enemyList = json["enemies"].ToArray();          
            ViewBag.Enemy = enemyList.Select(a => new SelectListItem { Text = a.name, Value = a.name }).ToList();
            ViewBag.levelOneEnemies = enemyList.Where(e => e.level == 1).Select(a => new SelectListItem { Text = a.name, Value = a.name }).ToList();

            // Set the player's name
            var player = new Player { PlayerName = playerName };
            level.Player = player;
            level.Player.Health = 100;

            //System.Diagnostics.Debug.WriteLine();
            // Pass the level object to the view
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