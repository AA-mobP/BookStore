using BookStore.Models.ViewModels;

namespace BookStore.Models.Repository
{
    public interface IclsCart
    {
        public List<CartItemModel> GetCartItems(string userId);
        void AddToCart(int bookId, string userId, int quantity = 1);
        void RemoveFromCart(int bookId, string userId);
        decimal GetTotalPrice(string userId);
    }
}
