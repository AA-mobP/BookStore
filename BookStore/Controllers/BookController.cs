using BookStore.Models;
using BookStore.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly IclsBook book;

        public BookController(IclsBook _book)
        {
            book = _book;
        }
        public IActionResult Index()
        {
            return View(book.GetAll());
        }

        public IActionResult Create()
        {
            return View(new BookModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BookModel newBook)
        {
            book.Create(newBook);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(book.GetOne(id));
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(BookModel newBook)
        {
            book.Update(newBook);
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            book.Delete(id);
            return RedirectToAction("index");
        }

        public IActionResult Details(int id)
        {
            return View(book.GetOne(id));
        }
    }
}
