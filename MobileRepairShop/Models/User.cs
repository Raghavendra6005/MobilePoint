using System.ComponentModel.DataAnnotations;

namespace MobileRepairShop.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        public string FullName { get; set; }
    }
}