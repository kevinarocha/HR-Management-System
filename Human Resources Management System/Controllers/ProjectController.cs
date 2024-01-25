using Human_Resources_Management_System.Data;
using Human_Resources_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Human_Resources_Management_System.Controllers
{
    public class ProjectController: Controller

    {
        public readonly ApplicationDbContext _context;

        public ProjectController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Projects()
        {
            List<Project> projects = _context.Projects.ToList();

            return View(projects);
        }
        public async Task<IActionResult> TaskList()
        {
            return View();
        }
        public async Task<IActionResult> FieldVisit()
        {
            return View();
        }

         [HttpPost]
        public async Task<IActionResult> Projects([Bind("ProjectTitle, ProjectStartDate, ProjectEndDate, Details, Summary, Status")] Project projects)
        {
            _context.Add(projects);

            await _context.SaveChangesAsync();
            return RedirectToAction("Project");
        }
    }
}
