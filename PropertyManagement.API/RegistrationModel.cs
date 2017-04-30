using System.ComponentModel.DataAnnotations;

namespace PropertyManagement.API
{
    public class RegistrationModel
    {
        [Required]
        public string EmailAddress { get; set; }

        [Required, MinLength(8), DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password do not match")]
        public string ConfirmPassword { get; set; }
    }
}