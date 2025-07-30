using LibraryManagementSystemWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace LibraryManagementSystemWebApp.Data
{
    public class LibraryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=LibraryWebAppDb;Trusted_Connection=True;Encrypt=false");
        }

        public DbSet<Book> Books { get; set; }
    }
}
