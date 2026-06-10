using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwabhimanHealthcareCMS.Models
{
    public class Card
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        [Required]
        [StringLength(16)]
        public string CardNumber { get; set; }

        public string? LivePhoto { get; set; }

        public string Status { get; set; } = "pending";

        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
