using LibraryManagementSystemWebApp.Data;
using LibraryManagementSystemWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystemWebApp.Controllers
{
    public class BookController : Controller
    {
        LibraryContext context = new();

        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {


                context.Books.Add(book);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(book);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var books = context.Books.ToList();
            return View(books);
        }
    }
}
