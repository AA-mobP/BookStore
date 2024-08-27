using BookStore.Models;
using BookStore.Models.BusinessLayer;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
	public class DetailsController : Controller
	{
		private IclsDetails _details;
		public DetailsController(IclsDetails details)
		{
			_details = details;
		}
		
		public IActionResult Index(int id)
		{
			BookModel book = _details.GetBook(id);
			ViewData["Genres"] = _details.GetGenres(id);
			ViewData["RelevantYear"] = _details.GetRelevantYear(book.PublishYear, 6);
			ViewData["RelevantAuthor"] = _details.GetRelevantAuthor(book.AuthorName, 6);
			ViewData["RelevantType"] = _details.GetRelevantType(book.Type, 6);
            return View(book);
		}
	}
}
