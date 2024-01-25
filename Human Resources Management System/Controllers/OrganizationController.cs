using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Human_Resources_Management_System.Data;
using Human_Resources_Management_System.Models;

namespace Human_Resources_Management_System.Controllers
{
    public class OrganizationController : Controller
    {

        //private readonly ApplicationDbContext _context;
        //private readonly IConfiguration _configuration;
        public readonly ApplicationDbContext _context;

        public OrganizationController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Department()
        {
            List<Department> departments = _context.Departments.ToList();

            return View(departments);
        }

        [HttpPost]
        public async Task<IActionResult> Department([Bind("DepartmentName")] Department department)
        {
            _context.Add(department);

            await _context.SaveChangesAsync();
            return RedirectToAction("Department");
        }


    }
}
