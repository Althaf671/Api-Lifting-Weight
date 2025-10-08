

namespace Backend.Domain.Entities
{
    //========== Refresh Session Entity ==========//
    public class RefreshSession
    {
        // Primary key
        public string Id { get; set; } = Guid.NewGuid().ToString();

        // Account Id
        public string AccountId { get; set; } = string.Empty; // Parent id

        // Account
        public Account Account { get; set; } = null!;

        // Refresh Token?
        public string? RefreshToken { get; set; }

        // Is Revoked
        public bool IsRevoked { get; set; } = false;

        // Device Info
        public string DeviceInfo { get; set; } = string.Empty;

        // Ip Address
        public string IpAddress { get; set; } = string.Empty;

        // Created at
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Ended At
        public DateTime ExpiresAt { get; set; }
    }
}