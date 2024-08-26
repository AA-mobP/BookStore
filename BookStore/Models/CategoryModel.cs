using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class CategoryModel
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        public ICollection<BookModel> Books { get; set; }
    }
}
