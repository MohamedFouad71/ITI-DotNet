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
                new Student(105, "Nour Walid", 20, "Computer Science", 3.88),
                new Student(106, "Youssef Ali", 21, "Medicine", 4.00),
                new Student(107, "Sara Ehab", 19, "Medicine", 3.65),
                new Student(108, "Adam Gasser", 23, "Medicine", 3.40),
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

            //Method 1
            var sortedByName = (from Student s in students
                               orderby s.Name
                               select s);
            Console.WriteLine("Sorted list by name : ");
            PrintEnumerable.Print(sortedByName);


            //Method2
            var sortedByName2 = students.OrderBy(s=>s.Name).ToList();
            Console.WriteLine("Sorted list by name method 2 : ");
            PrintEnumerable.Print(sortedByName);

            #endregion

            #region Group by

            //Method 1
            var GroupedByDepartment = students.GroupBy(s => s.Department).ToList(); // list of dictionaries
            Console.WriteLine("Grouped list by Department method 1 : ");

            foreach (var group  in GroupedByDepartment)
            {
                Console.WriteLine($"Department : {group.Key}");
                foreach (var value in group) Console.WriteLine(value);
                Console.WriteLine();
            }

            #endregion

            #region Count

            Dictionary<string, int> StudentsCountInEachDepartment = new();
            foreach (var group in GroupedByDepartment)
                StudentsCountInEachDepartment[group.Key] = group.Count();


            Console.WriteLine("Students Count in Each Department :");
            foreach (KeyValuePair<string, int> group in StudentsCountInEachDepartment)
                Console.WriteLine($"{group.Key} : {group.Value}");

            #endregion

            #region Highest Gpa 
            double maxGpa = students.Max(s => s.GPA);
            var studentsWithHighestGpa = students.Where(s => s.GPA == maxGpa).ToList();

            Console.WriteLine("\nStudents with highest Gpa");
            foreach (var student in studentsWithHighestGpa)
            {
                Console.WriteLine(student);
            }
            #endregion

            #region check if all students ages > 18

            var olderThan18Count = students.Where(s => s.Age > 18).Count();
            if (students.Count() == olderThan18Count)
                Console.WriteLine("All Students are older than 18");
            else
                Console.WriteLine("Not All Students are older than 18");

            #endregion

            #region Select CS Students

            var csStudents = students.Where(s => s.Department == "Computer Science").ToList();
            Console.WriteLine("\nCS Students : ");
            foreach (var s in csStudents)
                Console.WriteLine(s.Name);

            #endregion

            #region Highest 3 Gpas

            var sortedByGpa = students.OrderByDescending(s => s.GPA);
            var thirdStudent = sortedByGpa.Take(3).Last();
            var top3Students = sortedByGpa.TakeWhile(s => s.GPA >= thirdStudent.GPA);

            Console.WriteLine("\nStudents with highst 3 GPAs :");
            foreach (var student in top3Students)
            {
                Console.WriteLine(student.Name);
            }
            #endregion
        }


    }
}
