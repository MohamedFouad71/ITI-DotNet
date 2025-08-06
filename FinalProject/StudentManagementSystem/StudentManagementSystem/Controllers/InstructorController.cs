using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;
using StudentManagementSystem.Views.ViewModels;
using System.Security.Cryptography;

namespace StudentManagementSystem.Controllers
{
    public class InstructorController : Controller
    {
        UniversityContext _context;

        public InstructorController(UniversityContext context)
        {
            _context = context;
        }

        //####################################### Home ######################################
        public IActionResult Index()
        {
            var Instructors = _context.Instructors.Include(i => i.OfficeAssignment).ToList();
            return View(Instructors);
        }
        //###################################################################################


        //####################################### Instructor Add ############################
        [HttpGet]
        public IActionResult InstructorAdd()
        {
            return View();
        }


        public async Task<IActionResult> InstructorAdd(InstructorAddViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);


            var instructor = new Instructor()
            {
                Name = viewModel.InstructorName,
                HireDate = viewModel.InstructorHireDate
            };


            await _context.Instructors.AddAsync(instructor);
            await _context.SaveChangesAsync();


            if (viewModel.OfficeLocation != null)
            {
                OfficeAssignment office = new OfficeAssignment
                {
                    InstructorId = instructor.Id,
                    Location = viewModel.OfficeLocation
                };

                await _context.OfficeAssignments.AddAsync(office);
                await _context.SaveChangesAsync();
            }


            return RedirectToAction(nameof(Index));
                   
        }
        //###############################################################################



        //############################ Delete ###########################################
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> InstructorDelete(int id)
        {
            if (id == 0) return BadRequest("id not found");

            var instructor = await _context.Instructors.FindAsync(id);
            _context.Instructors.Remove(instructor);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        //###############################################################################

    }
}
