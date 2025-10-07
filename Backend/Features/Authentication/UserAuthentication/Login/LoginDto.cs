/**
 * Login DTO adalah Data Transfer Object
 * File ini adalah semacam kontrak yang
 * harus dipatuhi oleh class yang menggunakannya
*/
using System.ComponentModel.DataAnnotations;
using Backend.Features.Authentication.Shared.Validators;

namespace Backend.Features.Authentication.UserAuthentication.Login
{
    public class LoginRequest
    {
        // Request Email
        [Required]
        [EmailAddress]
        [MinLength(4)]
        public string Email { get; set; } = string.Empty;

        // Request Password
        [Required]
        [PasswordStandard]
        public string Password { get; set; } = string.Empty;

    }

    public class LoginResponse
    {
        // Response user Id
        public string Id { get; set; } = string.Empty;

        // Response Name
        public string Name { get; set; } = string.Empty;

        // Response Email 
        public string Email { get; set; } = string.Empty;

        // Response Status
        public bool Status { get; set; }

        // Response isVerified
        public bool IsVerified { get; set; }

        // Response isBlacklisted
        public bool IsBlacklisted { get; set; }
        
        // Response Pfp
        public string? Picture { get; set; }

        // Response Account dan datanya
        public AccountData? Account { get; set; }
        public class AccountData
        {
            // Response Nama provider
            public string Provider { get; set; } = string.Empty;

            // Response Id provider
            public string ProviderId { get; set; } = string.Empty;

        }
    }
}



