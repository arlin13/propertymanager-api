using System.ComponentModel.DataAnnotations;

namespace PropertyManagement.API.Models
{
    public class RegistrationModel
    {
        [Required]
        public int Username { get; set; }

        [Required, MinLength(8), DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}