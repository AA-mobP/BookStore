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
			ViewData["Categories"] = book.Categories.ToList();
			ViewData["RelevantYear"] = _details.GetRelevantYear(id, 6);
            return View();
		}
	}
}
