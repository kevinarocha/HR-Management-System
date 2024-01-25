
using Human_Resources_Management_System.Data;
using Human_Resources_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Human_Resources_Management_System.Controllers
{
    public class LeaveController:Controller
    {
        public readonly ApplicationDbContext _context;

        public LeaveController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> HolidayLeave()
        {
            List<LeaveHoliday> leaveHolidays = _context.LeaveHolidays.ToList();

            ViewData["MainText"] = "This is main text";
            ViewData["Subtext"] = "This is subtext";

            return View(leaveHolidays);
        }
        // How to add Holiday Leave with box submit transparent

        public async Task<IActionResult> LeaveType()
        {
            return View();
        }
        // How to add LeaveType with box submit transparent


        public async Task<IActionResult> LeaveApplication()
        {
            List<LeaveApplication> leaveApplications = _context.LeaveApplications.ToList();

            return View(leaveApplications);
        }
        public async Task<IActionResult> EarnedLeave()
        {
            return View();
        }

         [HttpPost]
        public async Task<IActionResult> HolidayLeave([Bind("HolidayName, StartDate, EndDate")] LeaveHoliday leaveHolidays)
        {
            _context.Add(leaveHolidays);

            await _context.SaveChangesAsync();
            return RedirectToAction("LeaveHoliday");
        }

         [HttpPost]
        public async Task<IActionResult> LeaveApplication([Bind("EmployeeName, Pin, LeaveType, EndDate, Duration, LeaveStatus")] LeaveApplication leaveApplications)
        {
            _context.Add(leaveApplications);

            await _context.SaveChangesAsync();
            return RedirectToAction("LeaveApplication");
        }

        // How to assign earned leave with box submit transparent


    }
}
