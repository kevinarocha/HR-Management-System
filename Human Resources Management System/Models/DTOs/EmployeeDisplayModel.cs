using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;

namespace Human_Resources_Management_System.Models.DTOs
{
    public class EmployeeDisplayModel
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}
