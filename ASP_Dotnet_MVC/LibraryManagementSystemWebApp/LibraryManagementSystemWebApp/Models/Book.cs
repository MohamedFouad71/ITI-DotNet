using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystemWebApp.Models
{
        
    public enum Category : byte { Novel, Science, History, Technology }

    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [StringLength(50,ErrorMessage = "Title Must not exceed 50 Characters")]
        public string BookTitle { get; set; }
        public string? Author { get; set; }
        public Category? Category { get; set; }
        [DataType(DataType.Date)]
        public DateTime? PublicationDate { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}