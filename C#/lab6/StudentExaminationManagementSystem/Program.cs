


using System.Diagnostics.Contracts;
using SEMS.Utilities;
using SEMS.Utilities.StudentClasses;

namespace SEMS
{
    class Program
    {
        static public void Main()
        {

            Student[] students =
            {
                new GraduateStudent() { Name = "Mohamed", Major = "CS"},
                new RegularStudent() {Name = "Ali" , Major ="IT"},
                new TransferStudent() {Name = "TransferStudent 1", Major = "AI" , PreviousUniversity ="Mansoura"},
                new ScholarshipStudent(){ Name = "Scholarship st", Major = "Electronics",ScholarshipAmmount = 50000 }
            };

            students[1].AddScore("OS", 98);
            students[1].AddScore("man", 89);
            students[1].AddScore("uip", 100);
            foreach (var student in students)
            {
                Console.WriteLine("******************************************************************************");
                student.Display();
                Console.WriteLine("******************************************************************************");
            }
        }
    }
}