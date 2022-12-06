namespace WebAuth.Models
{
    public class Job
    {
        public Guid Id { get; set; }
        public SupportStatuses SupportStatus { get; set; }
        public Customers Customers { get; set; }
        public Dock Dock { get; set; }
        public string LoadNo { get; set; }
        public int NoPallets { get; set; }
        public string LoadType { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
