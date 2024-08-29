using Microsoft.EntityFrameworkCore;
using BookStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace BookStore.Models
{
	public class BookDbContext : IdentityDbContext<ApplicationUser>
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) {}

        public DbSet<BookModel> tblBooks { get; set; }
        public DbSet<GenreModel> tblGenres { get; set; }
		public DbSet<ApplicationUser> ReaderModel { get; set; } = default!;
        public DbSet<BookUserModel> CartItems { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("production");

            modelBuilder.Entity<BookModel>(model =>
            {
                model.HasMany(x => x.Genres).WithMany(x => x.Books);
            });
        }
    }
}
