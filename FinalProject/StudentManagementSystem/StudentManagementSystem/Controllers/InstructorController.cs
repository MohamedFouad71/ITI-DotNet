using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;

namespace StudentManagementSystem.Controllers
{
    public class InstructorController : Controller
    {
        UniversityContext _context;

        public InstructorController(UniversityContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var Instructors = _context.Instructors.Include(i => i.OfficeAssignment).ToList();
            return View(Instructors);
        }
    }
}
