using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Human_Resources_Management_System.Models
{
    //[Table("Employee")]
    public class Employee: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeCode { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public string Role { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string NID { get; set; }
        public string ContactNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOfJoining { get; set; }
        public string DateOfLeaving { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
    }
}
