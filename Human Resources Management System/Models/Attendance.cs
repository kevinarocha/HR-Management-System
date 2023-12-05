using System.ComponentModel.DataAnnotations.Schema;

namespace Human_Resources_Management_System.Models
{
    [Table("Attendance")]
    public class Attendance
    {
        public int Id { get; set; }
        public string Employee { get; set; }
        public string Date { get; set; }
        public string SignInTime { get; set; }
        public string SignOutTime { get; set; }
        public string Place { get; set; }
    }
}
