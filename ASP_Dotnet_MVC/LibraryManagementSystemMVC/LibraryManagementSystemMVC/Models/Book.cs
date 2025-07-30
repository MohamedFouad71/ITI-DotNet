using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryBookManagement.Models
{
    public enum Category
    {
        Novel,
        Science,
        History,
        Technology
    }

    public class Book
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(100)]
        public string? Author { get; set; }

        public Category Category { get; set; }

        [DataType(DataType.Date)] // Client side validation, browser also renders a date picker, best practice with tag helper
        public DateTime PublicationDate { get; set; }

        public bool IsAvailable { get; set; }
    }
}
