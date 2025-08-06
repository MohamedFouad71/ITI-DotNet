using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;
using StudentManagementSystem.Views.ViewModels;

namespace StudentManagementSystem.Controllers
{
    public class CourseController : Controller
    {
        UniversityContext _context;

        public CourseController(UniversityContext context)
        {
            _context = context;
        }

        //######################## Home ###########################
        public IActionResult Index()
        {
            var courses = _context.Courses.ToList();
            return View(courses);
        }
        //#########################################################



        //####################### Add Course ######################
        public IActionResult CourseAdd()
        {
            CourseAddViewModel viewModel = new();
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CourseAdd(CourseAddViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);


            Course course = new()
            {
                Name = viewModel.Name,
                Credits = viewModel.Credits
            };


            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //#########################################################



        //##################### Course Delete #####################
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CourseDelete(int id)
        {
            if (id == 0)
                return BadRequest("id not found");


            Course course = await _context.Courses.FindAsync(id);


            if (course == null)
                return BadRequest("course not found");


            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
