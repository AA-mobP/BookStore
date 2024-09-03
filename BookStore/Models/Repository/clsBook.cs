
using NuGet.Packaging;

namespace BookStore.Models.Repository
{
    public class clsBook : IclsBook
    {
        private readonly BookDbContext context;

        public clsBook(BookDbContext _context)
        {
            context = _context;
        }
        public List<BookModel> GetAll()
        {
            return context.tblBooks.ToList();
        }

        public BookModel GetOne(int id)
        {
            return context.tblBooks.FirstOrDefault(x => x.BookId == id);
        }

        public void Create(BookModel book)
        {
            context.tblBooks.Add(book);
            context.SaveChanges();
        }
        public void Update(BookModel newBook)
        {
            BookModel book = context.tblBooks.FirstOrDefault(x => x.Name == newBook.Name);

            book.Name = newBook.Name;
            book.Price = newBook.Price;
            book.Synopsis = newBook.Synopsis;
            book.AuthorName = newBook.AuthorName;
            book.PhotoName = book.PhotoName;
            book.LeftQuantity = newBook.LeftQuantity;
            book.PublishYear = newBook.PublishYear;
            book.Type = newBook.Type;

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            BookModel book = context.tblBooks.FirstOrDefault(x => x.BookId == id);
            context.tblBooks.Remove(book);
            context.SaveChanges();
        }

    }
}
