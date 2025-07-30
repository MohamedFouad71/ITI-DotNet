using LibraryBookManagement.Models;
using LibraryManagementSystemMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystemMVC.Controllers
{
    public class BooksController : Controller
    {
        LibraryContext context = new();

        public IActionResult Index()
        {

            var AllBooks = context.Books.ToList();

            return View(AllBooks);
        }

        public IActionResult Details()
        {
            var requiredBook = context.Books.FirstOrDefault();

            if (requiredBook == null) return NotFound();

            return View(requiredBook);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] // Specifies verb to allow overloading
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Add(book);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(book);
        }
    }
}
