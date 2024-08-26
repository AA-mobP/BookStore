using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class BookModel
    {
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

        [Url]
        [MaxLength(100)]
        public string PhotoURL { get; set; }
        
        public ICollection<CategoryModel> Categories { get; set; }
    }
}
