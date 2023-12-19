using Microsoft.AspNetCore.Mvc;

namespace Human_Resources_Management_System.Controllers
{
    public class EmployeesController: Controller
    {


        public async Task<IActionResult> Employees()
        {

            //ViewData["MainText"] = "This is main text";
            //ViewData["SubText"] = "This is subtext";

            return View();
        }

        public async Task<IActionResult> AddEmployee()
        { 
            return View();
        }

        public async Task<IActionResult> DisciplinaryList()
        {
            return View();
        }




    }
}
