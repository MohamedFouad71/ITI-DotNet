

namespace SEMS.Utilities.StudentClasses
{
    abstract class Student
    {

        #region Fields and Properties
        static public HashSet<Student> AllStudents { get; set; } = [];
        protected string[,] subjectScores = new string[10, 2]; //name , grade
        int SubjectCount = 0;
        static int LastID = 0;
        public int ID { get; private set; }
        public string Name { get; set; } = "";
        public string Major { get; set; } = "";
        public StudentContact Contact { get; set; } = new();
        public bool IsActive { get; set; } = true;

        #endregion



        #region Constructors

        public Student()
        {
            ID = ++LastID;
            AllStudents.Add(this);
        }

        public Student(string name, string major) : this()
        {
            Name = name;
            Major = major;
        }

        #endregion



        #region Methods
        public virtual void AddScore(string subject, int score)
        {
            try
            {
                subjectScores[SubjectCount, 0] = subject;
                subjectScores[SubjectCount++, 1] = score.ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("Max number of subjects reached");
            }
        }

        public void DisplayGrades()
        {
            for (int i = 0; i < SubjectCount; i++)
                Console.Write($"|{subjectScores[i, 0]} Score is {subjectScores[i, 1]} |");

            Console.WriteLine();
        }

        protected void DisplayPersonnalInfo()
        {
            Console.WriteLine("Name : "+Name);
            Console.WriteLine("ID : "+ID);
            Console.Write("Grades : "); DisplayGrades();
        }

        public abstract void Display();

        #endregion
    }
}