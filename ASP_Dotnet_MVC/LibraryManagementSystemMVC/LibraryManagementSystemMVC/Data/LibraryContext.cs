using LibraryBookManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystemMVC.Data
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;Encrypt=False");
        }
    }
}
