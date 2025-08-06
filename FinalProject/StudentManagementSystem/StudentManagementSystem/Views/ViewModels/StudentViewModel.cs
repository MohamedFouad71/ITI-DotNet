using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Views.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        [Required, StringLength(100, ErrorMessage = "100 Characters Maximum")]
        public string Name { get; set; }

        [EmailAddress, Required]
        public string Email { get; set; }

        [DataType(DataType.Date), Required]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        public List<SelectListItem>? Departments { get; set; }
    }
}
