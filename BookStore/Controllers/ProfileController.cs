using BookStore.Models.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using BookStore.Models;

namespace BookStore.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
		private readonly IclsProfile profile;
        private readonly UserManager<ApplicationUser> user;

        public ProfileController(IclsProfile _profile, UserManager<ApplicationUser> _user)
        {
			profile = _profile;
            user = _user;
        }
        public async Task<IActionResult> Index()
        {
            ApplicationUser AppUser = await user.GetUserAsync(User);
            return View(AppUser);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ApplicationUser oldUser)
        {
            profile.EditUser(oldUser);
            return RedirectToAction("index");
        }
    }
}
