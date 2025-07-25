using LinqPractice.Utilities;

namespace LinqPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Data Entry
            // Creating 10 instances of the Student class
            List<Student> students = new List<Student>
            {
                new Student(101, "Aya Ahmed", 20, "Computer Science", 3.75),
                new Student(102, "Omar Hassan", 21, "Electrical Engineering", 3.50),
                new Student(103, "Lina Mostafa", 19, "Business Administration", 3.92),
                new Student(104, "Karim Tarek", 22, "Mechanical Engineering", 3.30),
                new Student(105, "Nour Walid", 20, "Architecture", 3.88),
                new Student(106, "Youssef Ali", 21, "Medicine", 4.00),
                new Student(107, "Sara Ehab", 19, "Pharmacy", 3.65),
                new Student(108, "Adam Gasser", 23, "Law", 3.40),
                new Student(109, "Hana Emad", 20, "Fine Arts", 3.70),
                new Student(110, "Ziad Mohamed", 22, "Civil Engineering", 3.55)
            };

            // Printing the details of each student
            Console.WriteLine("All Students Data");
            PrintEnumerable.Print(students);

            #endregion


            #region Query methods

            //Quering 
            var veryGoodGradeStudents = (from student in students
                                         where student.GPA > 3.5
                                         select student).ToList();

            //Prining Queried
            Console.WriteLine("\nStudents That are very good or above : ");
            PrintEnumerable.Print(veryGoodGradeStudents);


            //Method 2 

            var belowVeryGood = students.Where(s => s.GPA < 3.5).ToList();
            Console.WriteLine("\nStudents That are bellow very good : ");
            PrintEnumerable.Print(belowVeryGood);

            #endregion

            #region Aggregation funcs
            
            double avgGpa = students.Average(s => s.GPA);
            double avgGpa2 = students.Select(s => s.GPA).Average();

            Console.WriteLine($"\nAvg GPA = {avgGpa:f2} or {avgGpa2:f2}");

            #endregion

            #region Sort By

            var sortedByName = (from Student s in students
                               orderby s.Name
                               select s);
            Console.WriteLine("Sorted list by name : ");
            PrintEnumerable.Print(sortedByName);

            #endregion

        }


    }
}
