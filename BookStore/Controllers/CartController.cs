using BookStore.Models;
using BookStore.Models.Repository;
using BookStore.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly IclsCart cart;
        private readonly UserManager<ApplicationUser> userManagaer;

        public CartController(IclsCart _cart, UserManager<ApplicationUser> _userManagaer)
        {
            cart = _cart;
            userManagaer = _userManagaer;
            
        }
        public IActionResult Index()
        {
            List<CartItemModel> items = cart.GetCartItems(userManagaer.GetUserId(User));
            return View(items);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(int bookId, int quantity = 1)
        {
            cart.AddToCart(bookId, userManagaer.GetUserId(User), quantity);
            return Json(new {success = true, message = "Product added successfully." });
        }
        public IActionResult Delete(int bookId)
        {
            return View();
        }

    }
}
