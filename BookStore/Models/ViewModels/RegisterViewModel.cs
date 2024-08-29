using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.ViewModels
{
    public class RegisterViewModel
    {
        
        [Required]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(25)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(25)]
        public string Email { get; set; }

        [Required]
        [Phone]
        [MaxLength(25)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(25)]
        public string Governorate { get; set; }

        [Required]
        [MaxLength(25)]
        public string City { get; set; }

        [Required]
        [MaxLength(50)]
        public string DetailedAddress { get; set; }

        [Required]
        [MaxLength(5)]
        public string PostalCode { get; set; }
    }
}
