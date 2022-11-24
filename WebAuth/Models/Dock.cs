using System.ComponentModel.DataAnnotations;

namespace WebAuth.Models
{
    public class Dock
    {
        [Key]
        public Guid Id { get; set; }
        public string DockName { get; set; }
    }
}
