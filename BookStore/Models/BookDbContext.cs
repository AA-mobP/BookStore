using Microsoft.EntityFrameworkCore;

namespace BookStore.Models
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) {}

        public DbSet<BookModel> tblBooks { get; set; }
        public DbSet<GenreModel> tblGenres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("production");

            modelBuilder.Entity<BookModel>(model =>
            {
                model.HasMany(x => x.Genres).WithMany(x => x.Books);
            });
        }
    }
}
