using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManagementSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Views.ViewModels
{
    public class StudentAddViewModel
    {
        [Required, StringLength(100, ErrorMessage = "100 Characters Maximum")]
        public string Name { get; set; }

        [EmailAddress, Required]
        public string Email { get; set; }

        [DataType(DataType.Date), Required]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        public List<SelectListItem>? Departments { get; set; }
    }
}
