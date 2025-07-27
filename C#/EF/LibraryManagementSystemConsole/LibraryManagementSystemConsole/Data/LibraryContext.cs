using LibraryManagementSystemConsole.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystemConsole.Data
{
    public class LibraryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use the connection string from the appsettings.json file
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=LibraryManagementSystem;Trusted_Connection=True;Encrypt=false");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
