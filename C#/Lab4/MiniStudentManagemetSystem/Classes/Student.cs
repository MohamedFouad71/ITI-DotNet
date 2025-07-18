


namespace MiniStudentManagementSystem.Classes
{
    class Student
    {
        static HashSet<int> AllIDs = new();

        int id;
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public LinkedList<SubjectGrades> Grades { get; set; }
        public int ID
        {
            set
            {

                if (AllIDs.Contains(value))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"[Error], Student ID {value} Already Exists");
                    Console.ResetColor();
                    id = -1;
                }
                else
                {
                    id = value;
                    AllIDs.Add(value);
                }

            }
            get { return id; }

        }

        public double GetAvgGrade()
        {
            double sum = 0f;
            foreach (var subject in Grades)
            {
                sum += subject.Grade;
            }
            return sum / 10;
        }

        public Student()
        {
            Name = "Unspecifies";
            id = -1;
            Grades = new();
        }


    }
}