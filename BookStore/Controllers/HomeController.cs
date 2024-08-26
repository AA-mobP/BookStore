using BookStore.Models;
using BookStore.Models.BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IclsHome _home;

        public HomeController(ILogger<HomeController> logger, IclsHome home)
        {
            _logger = logger;
            _home = home;
        }

        public IActionResult Index()
        {
            return View(_home.ShowAll());
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
