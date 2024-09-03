using BookStore.Models;
using BookStore.Models.BusinessLayer;
using BookStore.Models.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
	public class DetailsController : Controller
	{
		private IclsDetails _details;
        private readonly IclsCart cart;
        private readonly UserManager<ApplicationUser> userManager;

        public DetailsController(IclsDetails details, IclsCart _cart, UserManager<ApplicationUser> _userManager)
		{
			_details = details;
            cart = _cart;
            userManager = _userManager;
        }
		
		public IActionResult Index(int id)
		{
			BookModel book = _details.GetBook(id);
			_details.CurrentBookId = id;
            ViewData["Genres"] = _details.GetGenres(id);
			ViewData["RelevantYear"] = _details.GetRelevantYear(book.PublishYear, 6);
			ViewData["RelevantAuthor"] = _details.GetRelevantAuthor(book.AuthorName, 6);
			ViewData["RelevantType"] = _details.GetRelevantType(book.Type, 6);
            ViewData["BooksNames"] = cart.GetCartItems(userManager.GetUserId(User)).Select(c => c.BookName).ToList();
            return View(book);
		}
	}
}
