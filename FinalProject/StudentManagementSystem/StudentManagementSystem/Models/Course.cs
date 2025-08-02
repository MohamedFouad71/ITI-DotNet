using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required,StringLength(50, ErrorMessage = "50 Characters Maximum")]
        public string Name { get; set; }

        [Range(0,6),Required]
        public short Credits { get; set; }

        //Navigation Properties
        public ICollection<Attendance>? Attendances { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; } 
    }
}
