using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAuth.Models
{
    public class Job
    {
        [Key]
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }
        public Guid SuportStatusId { get; set; }
        public Guid DockId { get; set; }

        public string LoadNo { get; set; }
        public int NoPallets { get; set; }
        public string LoadType { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }


        [ForeignKey("CustomerId")]
        public virtual Customers Customers { get; set; }

        [ForeignKey("SuportStatusId")]
        public virtual SupportStatuses SupportStatuses { get; set; }

        [ForeignKey("DockId")]
        public virtual Dock Dock { get; set; }




    }
}
