using System.ComponentModel.DataAnnotations.Schema;

namespace Human_Resources_Management_System.Models
{
    [Table("Department")]
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
    }
}
