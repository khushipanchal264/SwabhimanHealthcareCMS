namespace SwabhimanHealthcareCMS.Models
{
    public class DashboardViewModel
    {
        public int TotalCustomers { get; set; }

        public decimal TotalBalance { get; set; }

        public int ApprovedCards { get; set; }

        public int PendingCards { get; set; }

        public int RejectedCards { get; set; }

        public decimal UsedAmount { get; set; }
    }
}
