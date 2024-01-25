using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Human_Resources_Management_System.Models;
using Microsoft.Identity.Client;

namespace Human_Resources_Management_System.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }


        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveApplication> LeaveApplications { get; set; }
        public DbSet<LeaveHoliday> LeaveHolidays { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<Project> Projects { get; set; }


    }
}

