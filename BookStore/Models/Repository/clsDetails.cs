using BookStore.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Models.BusinessLayer
{
    public class clsDetails : IclsDetails
    {
        private readonly BookDbContext context;
        public int CurrentBookId { get; set; }
        private Random random;

        public clsDetails(BookDbContext dbContext)
        {
            context = dbContext;
        }
        public BookModel GetBook(int id)
        {
            BookModel model = context.tblBooks.FirstOrDefault(b => b.BookId == id);
            return model;
        }

        public List<BooksViewModel> GetRelevantAuthor(string author, int count)
        {
            random = new Random();
            var result = context.tblBooks.Where(b => b.AuthorName == author && b.BookId != CurrentBookId).Select(b => new BooksViewModel { Id = b.BookId, Name = b.Name, Price = b.Price, Photo = b.PhotoName }).Take(count).ToList();
            return result;
        }

        public List<BooksViewModel> GetRelevantType(string type, int count)
        {
            random = new Random();
            List<BooksViewModel> books = context.tblBooks.Where(b => b.Type == type && b.BookId != CurrentBookId).Select(b => new BooksViewModel { Id = b.BookId, Name = b.Name, Price = b.Price, Photo = b.PhotoName }).Take(count).ToList();
            return books;
        }

        public List<BooksViewModel> GetRelevantYear(int year, int count)
        {
            random = new Random();
            List<BooksViewModel> books = context.tblBooks.Where(b => b.PublishYear == year & b.BookId != CurrentBookId).Select(b => new BooksViewModel { Id = b.BookId, Name = b.Name, Price = b.Price, Photo = b.PhotoName }).Take(count).ToList();
            return books;
        }

        public List<string> GetGenres(int id)
        {
            return context.tblBooks.Include(b => b.Genres).Where(b => b.BookId == id).SelectMany(b => b.Genres).Select(g => g.Name).ToList();
        }
    }
}
