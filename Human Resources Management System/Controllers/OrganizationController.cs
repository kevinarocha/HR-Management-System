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

        public async Task<IActionResult> Department()
        {

            ViewData["MainText"] = "This is main text";
            ViewData["SubText"] = "This is subtext";

            return View();
        }


    }
}
