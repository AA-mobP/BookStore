using Microsoft.EntityFrameworkCore;

namespace BookStore.Models
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) {}

        public DbSet<BookModel> tblBooks { get; set; }
        public DbSet<CategoryModel> tblCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("production");

            modelBuilder.Entity<BookModel>(model =>
            {
                model.HasMany(x => x.Categories).WithMany(x => x.Books);
            });
        }
    }
}
