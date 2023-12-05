using System.ComponentModel.DataAnnotations.Schema;

namespace Human_Resources_Management_System.Models
{
    [Table("Payroll")]
    public class Payroll
    {

        public int Id { get; set; }
        public int Pin { get; set; }
        public string Employee { get; set; }
        public string Month { get; set; }
        public int Salary { get; set; }
        public int Loan { get; set; }
        public int Hours { get; set;  }

        public int Deduction { get; set; }

        public int TotalPaid { get; set; }

        public string PayDate { get; set; }

        public string Status { get; set; }
    }
}
