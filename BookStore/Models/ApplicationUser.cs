using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            CartItems = new List<BookUserModel>();
        }
        [Required]
        [MaxLength(25)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(25)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(25)]
        public string Governorate { get; set; }
        [Required]
        [MaxLength(25)]
        public string City { get; set; }
        [Required]
        [MaxLength(60)]
        public string DetailedAddress { get; set; }
        [Required]
        [MaxLength(5)]
        public string PostalCode { get; set; }
        public ICollection<BookUserModel> CartItems { get; set; }
    }
}
