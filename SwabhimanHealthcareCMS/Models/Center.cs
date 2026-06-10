using System.ComponentModel.DataAnnotations;
namespace SwabhimanHealthcareCMS.Models
{
    public class Center
    {
        public int Id { get; set; }

        [Required]
        public string CenterName { get; set; }

        [Required]
        public string CenterCode { get; set; }

        public string Area { get; set; }

        public string Location { get; set; }

        public string Phone { get; set; }

        public string Status { get; set; } = "Active";
        public ICollection<Customer> Customers { get; set; }
        public DateTime CreatedAt { get; set; }
            = DateTime.Now;
    }
}
