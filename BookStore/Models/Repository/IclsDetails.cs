using BookStore.Models.ViewModels;

namespace BookStore.Models.BusinessLayer
{
    public interface IclsDetails
    {
        BookModel GetBook(int id);
        List<BooksViewModel> GetRelevantAuthor(string author, int count);
        List<BooksViewModel> GetRelevantType(string type, int count);
        List<BooksViewModel> GetRelevantYear(int id, int count);
        List<string> GetGenres(int id);
    }
}
