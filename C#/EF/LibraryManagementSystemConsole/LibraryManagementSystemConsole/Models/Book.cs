using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystemConsole.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [StringLength(50)]
        [Required]
        public string BookTitle { get; set; }

        [StringLength(30)]
        public string? BookAuthor { get; set; }

        public int? YearPublished { get; set; }

        public int? CategoryId { get; set; }

        public Category? Category { get; set; }

        /// <summary>
        /// A list That Contains The Members That Have This Book
        /// </summary>
        public List<Member> Members { get; set; } = new();


        public override string ToString()
        {
            return $"Book(BookId={BookId}, Title='{BookTitle}', Author='{BookAuthor}', YearPublished={YearPublished}, CategoryId={CategoryId})";
        }

    }
}
