using Human_Resources_Management_System.Data;
using Human_Resources_Management_System.Models;
using Microsoft.AspNetCore.Mvc;


namespace Human_Resources_Management_System.Controllers
{
    public class AttendanceController:Controller
    {
        public readonly ApplicationDbContext _context;

        public AttendanceController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> AttendanceList()
        {
            List<Attendance> attendances = _context.Attendances.ToList();

            return View(attendances);
        }


        public async Task<IActionResult> AddAttendance()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AttendanceList([Bind("Employee, Date, SignInTime, SingOutTime, Place")] Attendance attendances)
        {
            _context.Add(attendances);

            await _context.SaveChangesAsync();
            return RedirectToAction("AttendanceList");
        }




    }
}
