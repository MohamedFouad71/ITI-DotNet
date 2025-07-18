using MiniStudentManagementSystem.Classes;


namespace MiniStudentManagementSystem
{
    class Program
    {
        static public void Main(string[] args)
        {
            Student[] students =
            {
                new() {Name = "Mohamed", ID = 1, Gender = Gender.Male} ,
                new() {Name = "Hana", ID = 2, Gender = Gender.Female} ,
                new() {Name = "Ahmed", ID = 3, Gender = Gender.Male}
            };

            foreach (var student in students)
            {
                Random r = new();
                StudentSubjectManager.AddSubjectGrade(student, "Math", r.NextDouble() * 4);
            }


            foreach (var student in students)
            {
                Random r = new();
                StudentSubjectManager.AddSubjectGrade(student, "Science", r.NextDouble() * 4);
            }

            foreach (var student in students)
            {
                Print.StudentData(student);
                Console.WriteLine();
            }

            Student WithHigherGrades = new();
            double maxAvgGrade = -1;
            foreach (var student in students)
            {
                if (student.GetAvgGrade() > maxAvgGrade)
                {
                    WithHigherGrades = student;
                    maxAvgGrade = student.GetAvgGrade();
                }
            }

            Console.WriteLine($"{WithHigherGrades.Name} has the highest avg grade of {WithHigherGrades.GetAvgGrade():f2}");
        }


    }
}