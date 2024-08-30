using BookStore.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
	public class PersonalController : Controller
	{
		public IActionResult AboutUs()
		{
			return View();
		}
		public IActionResult ContactUs()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> SendEmail(string email, string firstName, string lastName, string message)
		{
			EmailSender em = new EmailSender();
			await em.SendEmailAsync("bodyyousef169@gmail.com", $"{firstName} {lastName} - {email}", message);
			return RedirectToAction("ContactUs");
		}
	}
}
