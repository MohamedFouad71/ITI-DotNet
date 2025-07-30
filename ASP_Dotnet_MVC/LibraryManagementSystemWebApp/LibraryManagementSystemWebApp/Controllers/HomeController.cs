using System.Diagnostics;
using LibraryManagementSystemWebApp.Data;
using LibraryManagementSystemWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystemWebApp.Controllers
{
    public class HomeController : Controller
    {
        LibraryContext context = new();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var books = context.Books.ToList();
            return View(books);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
