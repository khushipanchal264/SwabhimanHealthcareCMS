using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwabhimanHealthcareCMS.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string PhoneNo { get; set; }

        public string Email { get; set; }

        public string? Vendor { get; set; }

        public string Status { get; set; } = "Active";

        public DateTime CreatedAt { get; set; }

        // New Fields
        public DateTime? DateOfBirth { get; set; }

        public string? Gender { get; set; }

        public string? BloodGroup { get; set; }

        public string? HealthStatus { get; set; }

        public string? Address { get; set; }

        public string? ProfilePhoto { get; set; }

        public string? State { get; set; }

        public string? District { get; set; }

        public string? Block { get; set; }

        public string? Ward { get; set; }

        public int? CenterId { get; set; }

        [ForeignKey("CenterId")]
        public string Center { get; set; }

        public ICollection<Card> Cards { get; set; } = new List<Card>();
        public bool IsActive { get; set; }
    }
}