using Human_Resources_Management_System.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Human_Resources_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Human_Resources_Management_System.Controllers
{
    public class EmployeesController : Controller
    {
        public readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Employees()

        {
            List<Employee> employees = _context.Employees.ToList();

            ViewData["MainText"] = "This is main text";
            ViewData["SubText"] = "This is subtext";

            return View(employees);
        }

        public async Task<IActionResult> AddEmployee()
        { 
            return View();
        }

        public async Task<IActionResult> DisciplinaryList()
        {
            return View();
        }

         [HttpPost]
        public async Task<IActionResult> Employees([Bind("FirstName, LastName, EmployeeCode, Department, Designation, Role, Gender, BloodGroup, NID, ContactNumber, DateOfBirth, DateOfJoining, DateOfLeaving, Username, Email, Image")] Employee employees)
        {
            _context.Add(employees);

            await _context.SaveChangesAsync();
            return RedirectToAction("Employee");
        }




    }
}
