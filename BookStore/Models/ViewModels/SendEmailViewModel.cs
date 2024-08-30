using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.ViewModels
{
    public class SendEmailViewModel
    {
        public string email { get; set; } = "bodyyousef169@outlook.com";
        public string firstName { get; set; } = "From";
        public string lastName { get; set; } = "Anonymous";
        [Required]
        public string message { get; set; }
    }
}
