using Microsoft.AspNetCore.Mvc;


namespace Human_Resources_Management_System.Controllers
{
    public class AttendanceController:Controller
    {


        public async Task<IActionResult> AttendanceList()
        {

            return View();
        }


        public async Task<IActionResult> AddAttendance()
        {

            return View();
        }





    }
}
