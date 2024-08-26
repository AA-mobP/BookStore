using BookStore.Models.ViewModels;

namespace BookStore.Models.BusinessLayer
{
    public class clsDetails : IclsDetails
    {
        public BookModel GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public List<BooksViewModel> GetRelevantAuthor(int id, int count)
        {
            throw new NotImplementedException();
        }

        public List<BooksViewModel> GetRelevantType(string type, int count)
        {
            throw new NotImplementedException();
        }

        public List<BooksViewModel> GetRelevantYear(int id, int count)
        {
            throw new NotImplementedException();
        }
    }
}
