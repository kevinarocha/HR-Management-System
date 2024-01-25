using Human_Resources_Management_System.Data;
using Human_Resources_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Human_Resources_Management_System.Controllers
{
    public class PayrollController: Controller
    {
        public readonly ApplicationDbContext _context;

        public PayrollController(ApplicationDbContext context)
        {
            _context = context;
        }
    
        public async Task<IActionResult> PayrollList()

        {
            List<Payroll> payroll = _context.Payrolls.ToList();

            return View(payroll);
        }

         [HttpPost]
        public async Task<IActionResult> PayrollList([Bind("Pin, Employee, Month, Salary, Loan, Hours, Deduction, TotalPaid, PayDate, Status")] Payroll payroll)
        {
            _context.Add(payroll);

            await _context.SaveChangesAsync();
            return RedirectToAction("PayrollList");
        }
    }
}
