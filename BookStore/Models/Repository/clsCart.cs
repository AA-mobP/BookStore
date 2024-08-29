using Microsoft.EntityFrameworkCore;

namespace BookStore.Models.Repository
{
    public class clsCart
    {
        private BookDbContext context;
        public clsCart(BookDbContext _context)
        {
            context = _context;
        }

        //public void Delete(int id)
        //{
        //    context.tblCarts.Delete(id);
        //    context.SaveChanges();
        //}
    }
}
