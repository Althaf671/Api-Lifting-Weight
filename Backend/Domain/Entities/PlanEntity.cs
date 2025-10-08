

namespace Backend.Domain.Entities
{
    //========== Plan Entity ==========//
    public class Plan
    {
        // Primary key
        public string Id { get; set; } = Guid.NewGuid().ToString();

        // User Id
        public string UserId { get; set; } = string.Empty; // Parent id

        // User
        public User User { get; } = null!; // Relasi ke parent

        // Type
        public PlanType PlanType { get; set; } // Relasi ke enum

        // Price
        public double Price { get; set; }

        // Is Active
        public bool IsPlanActive { get; set; } = true;

        // Qr Token
        public string QrToken { get; set; } = string.Empty;

        // Start date
        public DateTime StartDate { get; set; } = DateTime.UtcNow;

        // End date
        public DateTime EndDate { get; set; }

        // Stripe Subcription Id?
        public string? StripeSubId { get; set; }

        // Stripe Invoice Id?
        public string? StripeInvoiceId { get; set; }

        /* TO-DO: ENUM FOR PLAN */
    }

    // Enums
    public enum PlanType
    {
        DAILY,
        WEEKLY,
        MONTHLY,
        YEARLY 
    }
}