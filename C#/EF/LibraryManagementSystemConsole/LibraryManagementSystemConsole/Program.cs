using LibraryManagementSystemConsole.Data;
using LibraryManagementSystemConsole.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace LibraryManagementSystemConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryContext db = new();

            #region Create and Add Seed Data
            //// Ensure the database is created
            ////db.Database.EnsureDeleted();
            ////db.Database.EnsureCreated();


            //var categories = new[]
            //{
            //    new Category { CategoryName = "Software Engineering" },
            //    new Category { CategoryName = "Programming" },
            //    new Category { CategoryName = "Design" }
            //};
            //db.Categories.AddRange(categories);



            //var members = new[]
            //{
            //    new Member { MemberName = "Alice" },
            //    new Member { MemberName = "Bob" },
            //    new Member { MemberName = "Charlie" }
            //};
            //db.Members.AddRange(members);



            //var books = new[]
            //{
            //    new Book
            //    {
            //        BookTitle = "Clean Code",
            //        BookAuthor = "Robert C. Martin",
            //        //CategoryId = 1
            //    },
            //    new Book
            //    {
            //        BookTitle = "The Pragmatic Programmer",
            //        BookAuthor = "Andrew Hunt",
            //        //CategoryId = 2
            //    },
            //    new Book
            //    {
            //        BookTitle = "Design Patterns",
            //        BookAuthor = "Erich Gamma",
            //        //CategoryId = 3
            //    }
            //};
            //db.Books.AddRange(books);



            //db.SaveChanges();
            #endregion



            #region CRUD

            //Create:
            db.Books.Add(new Book { BookTitle = "Grokking Algorithms", YearPublished = 2003, CategoryId = 8 });
            db.Borrows.Add(new Borrow() { BookId = 8, MemberId = 8 });
            db.Members.Add(new Member() { MemberName = "Ali Sawei", MembershipDate = new DateTime (2025, 3, 1) });
            db.Categories.Add(new Category() { CategoryName = "Telecommunication" });


            //Read:
            var books = db.Books.ToList();
            var categories = db.Categories.ToList();
            var borrows = db.Borrows.ToList();
            var members = db.Members.ToList();

            foreach ( var item in books)
            {
                Console.WriteLine(item);
            }


            //Update
            var firstBook = db.Books.First();
            firstBook.BookTitle = "Updated Title";

            
            //Delete
            var toUpdateBook = db.Books.Where(b=>b.BookId ==3).FirstOrDefault();
            toUpdateBook.BookAuthor = "Cristiano Ronaldo";

            db.SaveChanges();
            #endregion

            #region Linq

            // list all borrowed books

            var allBorrowedBooks = db.Borrows.Include(borrow=>borrow.Book).ToList();

            Console.WriteLine("Borrowed Books :");
            foreach (var item in borrows) { Console.WriteLine(item.Book); }


            //list the members that borrowed more than 3 books
            var membersWithMoreThan3Borrows = db.Borrows
                                            .GroupBy(b => b.MemberId)
                                            .Where(g => g.Count() > 3)
                                            .Select(g => new
                                            {
                                                MemberId = g.Key,
                                                BorrowCount = g.Count(),
                                                MemberName = db.Members
                                                    .Where(m => m.MemberId == g.Key)
                                                    .Select(m => m.MemberName)
                                                    .FirstOrDefault()
                                            }).ToList();


            foreach (var member in membersWithMoreThan3Borrows)
            {
                Console.WriteLine($"Member: {member.MemberName}, Borrowed Books: {member.BorrowCount}");
            }

            #endregion
        }
    }
}
