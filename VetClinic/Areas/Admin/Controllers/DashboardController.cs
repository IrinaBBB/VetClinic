using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using VetClinic.Data;
using VetClinic.Models;

namespace VetClinic.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly ILogger<DashboardController> _logger;
        private readonly AppDbContext _dbContext;

        public DashboardController(AppDbContext dbContext, ILogger<DashboardController> logger)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Animals()
        {
            var animals = _dbContext.Animals.Include(s => s.Species).ToList();
            return View(animals);
        }

        public IActionResult Owners()
        {
            return View();
        }

        public IActionResult Vets()
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
