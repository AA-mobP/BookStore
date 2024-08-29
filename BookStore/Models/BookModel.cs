using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace BookStore.Models
{
    public class BookModel
    {
        public BookModel()
        {
            CartItems = new List<BookUserModel>();
        }

        [Key]
        public int BookId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string AuthorName { get; set; }

        [Required]
        [Range(0, 5000.99)]
        public decimal Price { get; set; }

        [MaxLength(1000)]
        public string Synopsis { get; set; }

        [Required]
        [Range(0, 3000)]
        public int PublishYear { get; set; }

        [MaxLength(50)]
        public string PhotoName { get; set; }
        public int LeftQuantity { get; set; }
        [MaxLength(25)]
        public string Type { get; set; }
        public ICollection<GenreModel> Genres { get; set; }
        public ICollection<BookUserModel> CartItems { get; set; }
    }
}
