

using System.ComponentModel.DataAnnotations;
using Backend.Features.Authentication.Shared.Validators;


/**
 * Register DTO adalah Data Transfer Object
 * File ini adalah semacam kontrak yang
 * harus dipatuhi oleh class yang menggunakannya
*/
namespace Backend.Features.Authentication.UserAuthentication.Register
{
    public class RegisterRequestDto
    {
        // First name
        [Required]
        public string FirstName { get; set; } = string.Empty;

        // Last name
        [Required]
        public string LastName { get; set; } = string.Empty;

        // Email
        [Required]
        [EmailAddress]
        [MinLength(4)]
        public string Email { get; set; } = string.Empty;

        // Password 
        [Required]
        [PasswordStandard]
        public string Password { get; set; } = string.Empty;
    }

    public class RegisterResponseDto
    {
        // Cookie pending email
        public string PendingEmail { get; set; } = string.Empty;
        
    }
}