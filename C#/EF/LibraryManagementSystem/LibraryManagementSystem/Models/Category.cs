using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [StringLength(20)]
        [Required]
        public string CategoryName { get; set; }

        public List<Book> Books { get; set; } = new();

        public override string ToString()
        {
            return $"ID={CategoryId}, Category={CategoryName}";
        }
    }
}
