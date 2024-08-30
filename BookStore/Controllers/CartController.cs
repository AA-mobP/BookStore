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
            ViewData["Total"] = cart.GetTotalPrice(userManagaer.GetUserId(User));
            return View(items);
        }
        [HttpPost]
        public IActionResult Add(int bookId, int quantity = 1)
        {
            cart.AddToCart(bookId, userManagaer.GetUserId(User), quantity);
            return Json(new { success = true });
        }
        
        public IActionResult Delete(int itemId)
        {
            cart.RemoveFromCart(itemId);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult ChangeQuantity(int cartId, int newQuantity, decimal price, decimal allTotal)
        {
            cart.EditQuantity(cartId, newQuantity);
            decimal onetPrice = price * newQuantity;
            decimal allPrice = allTotal + price;
            return Json(new { success = true, oneTotal = onetPrice, allTotal = allPrice});
        }
    }
}
