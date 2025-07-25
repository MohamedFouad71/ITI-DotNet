using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice.Utilities
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Unspecified";
        public int Age { get; set; }
        public string Department { get; set; }
        public double GPA { get; set; }

        // Optional: Constructor to easily create Student objects
        public Student(int id, string name, int age, string department, double gpa)
        {
            Id = id;
            Name = name;
            Age = age;
            Department = department;
            GPA = gpa;
        }

        // Optional: Override ToString() for easy printing
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}, Department: {Department}, GPA: {GPA}";
        }
    }
}
