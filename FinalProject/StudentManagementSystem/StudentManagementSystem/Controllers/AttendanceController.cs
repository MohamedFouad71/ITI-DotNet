using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;

namespace StudentManagementSystem.Controllers
{
    public class AttendanceController : Controller
    {
        UniversityContext _context;

        public AttendanceController(UniversityContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var attendance = _context.Attendances.Include(a => a.Course).Include(a => a.Student).ToList();
            return View(attendance);
        }
    }
}
