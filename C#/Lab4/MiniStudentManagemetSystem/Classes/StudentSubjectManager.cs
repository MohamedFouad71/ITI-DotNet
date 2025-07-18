


namespace MiniStudentManagementSystem.Classes
{
    class StudentSubjectManager
    {
        static public void AddSubjectGrade(Student s, string subjectName, double Grade)
        {
            SubjectGrades SG = new();
            SG.Name = subjectName;
            SG.Grade = Grade;
            s.Grades.AddLast(SG);
        }

        static public void DeleteSubjectGrade(Student s, string subjectName)
        {
            foreach (var subject in s.Grades)
            {
                if (subject.Name == subjectName) s.Grades.Remove(subject);
                return;
            }

            Console.WriteLine($"[Error] Subject {subjectName} Is not found for Student {s.Name}");
        }


    }
}