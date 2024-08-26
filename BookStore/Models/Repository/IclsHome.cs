using BookStore.Models.ViewModels;

namespace BookStore.Models.BusinessLayer
{
    public interface IclsHome
    {
        List<BooksViewModel> ShowAll();
    }
}
