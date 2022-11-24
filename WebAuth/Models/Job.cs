namespace WebAuth.Models
{
    public class Job
    {
        public Guid Id { get; set; }
        public string LoadNo { get; set; }
        public SupportStatuses SupportStatus { get; set; }
        public Guid StatusID { get; set; }
        public Customers Customers { get; set; }
        public Guid CustomerID { get; set; }
        public Dock Dock { get; set; }
        public Guid DockID { get; set; }
        public int NoPallets { get; set; }
        public string LoadType { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DockOn { get; set; }
        public DateTime DockOff { get; set; }
    }
}
