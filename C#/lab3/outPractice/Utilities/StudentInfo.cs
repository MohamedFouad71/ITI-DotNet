



namespace outPractice.Utilites
{
    class StudentInfo
    {
        public static void GetStudentInfo(string name, out int age, out double grade)
        {
            Random r = new();
            age = r.Next(23);
            grade = r.NextDouble() * 100.0;
        }
    }
}