using BookStore.Models.ViewModels;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Models.Repository
{
    public class clsCart : IclsCart
    {
        private BookDbContext context;
        public clsCart(BookDbContext _context)
        {
            context = _context;
        }

        public List<CartItemModel> GetCartItems(string userId)
        {
            List<CartItemModel> items = (List<CartItemModel>)context.CartItems.Where(x => x.UserId == userId && x.OrderStatus == "Added").Include(x => x.Book).Select(x =>
            new CartItemModel { ItemId = x.CartId, BookName = x.Book.Name, BookPrice = x.Book.Price, PhotoName = x.Book.PhotoName, Quantity = x.Quantity, TotalPriceOfOneCartItem = (x.Quantity * x.Book.Price)}).ToList();
            return items;
        }

        public void AddToCart(int bookId, string userId, int quantity = 1)
        {
            BookUserModel cart = new BookUserModel() { AddToCartDate = DateTime.Now, BookId = bookId, UserId = userId, Quantity = quantity, OrderStatus = "Added" };

            context.CartItems.Add(cart);
            context.SaveChanges();
        }

        public void RemoveFromCart(int bookId, string userId)
        {
            BookUserModel cart = context.CartItems.First(x => x.BookId == bookId & x.UserId == userId);

            context.CartItems.Remove(cart);
            context.SaveChanges();
        }

        public decimal GetTotalPrice(string userId)
        {
            var Items = context.CartItems.Where(x => x.UserId == userId && x.OrderStatus == "Added").Include(x => x.Book).ToList();
            decimal total = 0;
            
            foreach (var item in Items)
            {
                total += item.Book.Price * item.Quantity;
            }
            return total;
        }
    }
}
