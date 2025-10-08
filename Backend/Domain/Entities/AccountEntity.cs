

namespace Backend.Domain.Entities
{
    //========== Account Entity ==========//
    public class Account
    {
        // Primary key
        public string Id { get; set; } = string.Empty;

        // User Id
        public string UserId { get; set; } = string.Empty; // Parent id

        // User 
        public User User { get; set; } = null!; // Connect tabel ke parent

        // Provider?
        public string? Provider { get; set; }

        // ProviderId?
        public string? ProviderId { get; set; }

        // Reset token?
        public string? ResetToken { get; set; }

        // Session 
        public ICollection<RefreshSession> RefreshSessions { get; } = []; // Account as parent dengan one to many

        // Abusive
        public ICollection<Abusive> Abusives { get; } = []; // Account as parent dengan one to many
    }
}