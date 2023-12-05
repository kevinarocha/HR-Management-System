using System.ComponentModel.DataAnnotations.Schema;

namespace Human_Resources_Management_System.Models
{
    [Table("LeaveApplication")]
    public class LeaveApplication
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public int Pin { get; set; }
        public string LeaveType { get; set; }
        public string EndDate { get; set; }
        public string Duration { get; set; }
        public string LeaveStatus { get; set; }
    }
}
