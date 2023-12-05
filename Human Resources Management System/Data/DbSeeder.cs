using Microsoft.AspNetCore.Identity;
using Human_Resources_Management_System.Enums;
using Human_Resources_Management_System.Models;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Human_Resources_Management_System.Data
{
    public class DbSeeder
    {

        private readonly ApplicationDbContext _dbContext;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<Employee> _userManager;

        public DbSeeder(ApplicationDbContext dbContext, RoleManager<IdentityRole> roleManager, UserManager<Employee> userManager)
        {
            _dbContext = dbContext;
            _roleManager = roleManager;
            _userManager = userManager;
        }


        //public async Task ManageDataAsync()
        //{

        //    //await _dbContext.Database.MigrateAsync();
        //    await _dbContext.Database.MigrateAsync();
        //    await SeedRolesAsync();
        //    await SeedUsersAsync();
        //}


        //public async Task ManageDataAsync()
        //{
        //    await _dbContext.Database.MigrateAsync();
        //    await SeedRolesAsync();
        //    await SeedUsersAsync();
        //}


        //private async Task SeedRolesAsync()
        //{
        //    // If there are already roles in the system, do not seed.
        //    if (_dbContext.Roles.Any())
        //    {
        //        return;
        //    }

        //    // Otherwise, seed roles.
        //    foreach (var role in Enum.GetNames(typeof(HRRoles)))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole(role));
        //    }


        //}



        //private async Task SeedUsersAsync()
        //{
        //    // If there are already users in the system, do not seed.
        //    if (_dbContext.Users.Any())
        //    {
        //        return;
        //    }

        //    var adminUsername = "admin";
        //    var adminPassword = "AdminPass123!";


        //    // Otherwise, seed the user
        //    Employee adminUser = new Employee()
        //    {

        //        FirstName = "John",
        //        LastName = "Doe",
        //        EmployeeCode = 1,
        //        Department = "IT",
        //        Designation = "Administrator",
        //        Role = "Admin",
        //        Gender = "Male",
        //        BloodGroup = "A+",
        //        NID = "1312930192",
        //        ContactNumber = "123-456-2289",
        //        DateOfBirth = "1/1/2023",
        //        DateOfJoining = "06/23/2023",
        //        DateOfLeaving = "07/23/2023",
        //        Username = "Admin",
        //        Email = "admin@gmail.com",
        //        Image = "efooef"


        //    };

        //    await _userManager.CreateAsync(adminUser, adminPassword);
        //    await _userManager.AddToRoleAsync(adminUser, HRRoles.Administrator.ToString());

        //}



        public static async Task SeedDefaultData(IServiceProvider service)
        {
            var userMgr = service.GetService<UserManager<IdentityUser>>();
            var roleMgr = service.GetService<RoleManager<IdentityRole>>();
            // adding some roles to db
            
            
            //await roleMgr.CreateAsync(new IdentityRole(HRRoles.Administrator.ToString()));
            //await roleMgr.CreateAsync(new IdentityRole(HRRoles.Employee.ToString()));


            // create admin user

            //var admin = new IdentityUser
            //{
            //    UserName = "admin@gmail.com",
            //    Email = "admin@gmail.com",
            //    EmailConfirmed = true,

            //};


            //    // Otherwise, seed the user
            Employee adminUser = new Employee()
            {

                FirstName = "John",
                LastName = "Doe",
                EmployeeCode = 1,
                Department = "IT",
                Designation = "Administrator",
                Role = "Admin",
                Gender = "Male",
                BloodGroup = "A+",
                NID = "1312930192",
                ContactNumber = "123-456-2289",
                DateOfBirth = "1/1/2023",
                DateOfJoining = "06/23/2023",
                DateOfLeaving = "07/23/2023",
                Username = "Admin",
                Email = "admin@gmail.com",
                Image = "efooef"


            };


            // No email verification just yet.
            //var userInDb = await userMgr.FindByEmailAsync(admin.Email);
            //if (userInDb is null)
            //{
                //await userMgr.CreateAsync(adminUser, "Admin@123");
                //await userMgr.AddToRoleAsync(adminUser, HRRoles.Administrator.ToString());
            //}

        }

    }
}
