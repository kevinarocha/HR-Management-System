using Microsoft.AspNetCore.Mvc;

namespace Human_Resources_Management_System.Controllers
{
    public class LeaveController:Controller
    {

        public async Task<IActionResult> HolidayLeave()
        {
            return View();
        }
        // How to add Holiday Leave with box submit transparent

        public async Task<IActionResult> LeaveType()
        {
            return View();
        }
        // How to add LeaveType with box submit transparent


        public async Task<IActionResult> LeaveApplication()
        {
            return View();
        }

        public async Task<IActionResult> EarnedLeave()
        {
            return View();
        }

        // How to assign earned leave with box submit transparent


    }
}
