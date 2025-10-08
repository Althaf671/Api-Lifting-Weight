/**
 * User model, untuk mendefenisikan
 * skema user di sebagai tabel di
 * database
 */
using System.ComponentModel.DataAnnotations;
using Backend.Features.Authentication.Shared.Validators;


namespace Backend.Domain.Entities
{
    //========== User Entity ==========//
    public class User
    {
        // Primary key - User Id
        public string Id { get; set; } = Guid.NewGuid().ToString(); // Guid

        // First name
        [Required]
        [MinLength(4)]
        [MaxLength(10)]
        public string FirstName { get; set; } = string.Empty;

        // Last name
        [Required]
        [MinLength(4)]
        [MaxLength(10)]
        public string LastName { get; set; } = string.Empty;

        // Email
        [Required]
        [EmailAddress]
        [MinLength(4)]
        public string Email { get; set; } = string.Empty;

        // Password?
        [PasswordStandard]
        public string? Password { get; set; }

        // Status is Active
        public bool IsStatusActive { get; set; } = true; // Default value true

        // Is Verified
        public bool IsVerified { get; set; } = false; // Default value false

        // Is Blacklisted
        public bool IsBlacklisted { get; set; } = false;

        // Created At
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Account
        public Account? Account { get; set; } // User as parent dengan one to one

        // Plans
        public ICollection<Plan> Plans { get; } = []; // User as parent dengan relasi one to many
    }
}