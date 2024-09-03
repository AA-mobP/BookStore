namespace BookStore.Models.Repository
{
    public interface IclsBook
    {
        List<BookModel> GetAll();
        BookModel GetOne(int id);
        void Create(BookModel book);
        void Update(BookModel newBook);
        void Delete(int id);
    }
}
