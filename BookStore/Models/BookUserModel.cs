using NuGet.Protocol.Core.Types;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace BookStore.Models
{
    public class BookUserModel
    {
        [Key]
        public int CartId { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public BookModel Book { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int Quantity { get; set; } = 1;
        public DateTime AddToCartDate { get; set; }
        public DateTime OrderData { get; set; }
        public DateTime CompleteDate { get; set; }
        [Required]
        [MaxLength(15)]
        public string OrderStatus { get; set; }
    }
}
