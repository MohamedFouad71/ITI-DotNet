using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Data;

namespace StudentManagementSystem.Controllers
{
    public class DepartmentController : Controller
    {
        UniversityContext _context;

        public DepartmentController(UniversityContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var Departments = _context.Departments.ToList();
            return View(Departments);
        }
    }
}
