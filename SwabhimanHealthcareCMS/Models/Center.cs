using System.ComponentModel.DataAnnotations;
namespace SwabhimanHealthcareCMS.Models
{
    public class Center
    {
        public int Id { get; set; }

        [Required]
        public string CenterName { get; set; }
        public string Email { get; set; }

        [Required]
        public string CenterCode { get; set; }

        public string Area { get; set; }

        public string Location { get; set; }
        public string District { get; set; }
        public string Block { get; set; }
        public string Pincode { get; set; }

        public string Phone { get; set; }
        public string Status { get; set; }
        public string State { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<Customer> Customers { get; set; } = new List<Customer>();
        public DateTime CreatedAt { get; set; }
            = DateTime.Now;
    }
}
