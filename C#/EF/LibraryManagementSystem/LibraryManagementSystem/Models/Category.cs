using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = "Unspecified";

        public override string ToString()
        {
            return $"ID={CategoryId}, Category={CategoryName}"
        }
    }
}
