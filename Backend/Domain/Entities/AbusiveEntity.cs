

namespace Backend.Domain.Entities
{
    //========== Abusive Entity ==========//
    public class Abusive
    {
        // Primary key
        public string Id { get; set; } = string.Empty;

        // Account Id 
        public string AccountId { get; set; } = string.Empty;

        // Account
        public Account Account { get; set; } = null!;

        // Ip address
        public string IpAddress { get; set; } = string.Empty;
    }
}