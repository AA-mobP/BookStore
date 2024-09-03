using BookStore.Models;
using BookStore.Models.BusinessLayer;
using BookStore.Models.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IclsHome _home;
        private readonly IclsCart cart;
        private readonly UserManager<ApplicationUser> userManager;

        public HomeController(ILogger<HomeController> logger, IclsHome home, IclsCart _cart, UserManager<ApplicationUser> _userManager)
        {
            _logger = logger;
            _home = home;
            cart = _cart;
            userManager = _userManager;
        }

        public IActionResult Index()
        {
            ViewData["BooksNames"] = cart?.GetCartItems(userManager.GetUserId(User))?.Select(c => c.BookName).ToList();
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
