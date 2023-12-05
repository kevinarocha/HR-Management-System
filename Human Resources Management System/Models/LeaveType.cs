using System.ComponentModel.DataAnnotations.Schema;

namespace Human_Resources_Management_System.Models
{
    [Table("LeaveType")]
    public class LeaveType
    {
        public int Id { get; set; }
        public string LeaveName { get; set; }
        public int Days { get; set; }
        public string Status { get; set; }
    }
}
