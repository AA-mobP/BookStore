using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
	public class DetailsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
