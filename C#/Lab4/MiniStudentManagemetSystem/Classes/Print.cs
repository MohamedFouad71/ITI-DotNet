


namespace MiniStudentManagementSystem.Classes
{
    static class Print
    {
        static public void StudentData(Student s)
        {
            Console.WriteLine($"Name : {s.Name} | ID : {s.ID} | Gender : {s.Gender}");
            StudentGrades(s);
            Console.WriteLine($"Avg Grade : {s.GetAvgGrade():f2}");
        }

        static public void StudentGrades(Student s)
        {
            foreach (var subject in s.Grades)
                Console.WriteLine($"Subject {subject.Name} Grade : {subject.Grade:f2}");
        }

    }
    
}