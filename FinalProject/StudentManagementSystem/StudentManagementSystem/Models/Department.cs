﻿using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required,StringLength(50, ErrorMessage = "50 Characters Maximum")]
        public string Name { get; set; }

        //Navigation Properties
        public ICollection<Student>? Students { get; set; }
    }
}
