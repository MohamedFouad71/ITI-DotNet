using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        public string Title { get; set; } = "Unspecified";

        public string? Author { get; set; } = "Unspecified";

        public int? YearPublished { get; set; }

        [ForeignKey(nameof(Category))]
        public int? CategoryId { get; set; }


        public Book()
        {
            //
        }

        public Book(int bookId, string title, string author, int yearPublished, int categoryId)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            YearPublished = yearPublished;
            CategoryId = categoryId;
        }

        public override string ToString()
        {
            return $"Book(BookId={BookId}, Title='{Title}', Author='{Author}', YearPublished={YearPublished}, CategoryId={CategoryId})";
        }

    }
}
