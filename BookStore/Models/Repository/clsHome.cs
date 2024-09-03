using BookStore.Models.ViewModels;

namespace BookStore.Models.BusinessLayer
{
    public class clsHome : IclsHome
    {
        private readonly BookDbContext context;

        public clsHome(BookDbContext dbContext)
        {
            context = dbContext;
        }

        public List<BooksViewModel>? ShowAll()
        {
            var result =  context.tblBooks.Select(b =>
            new BooksViewModel { Id = b.BookId, Name = b.Name, Price = b.Price, Photo = b.PhotoName}).ToList();
            return result;
        }
    }
}
