namespace SEMS.Utilities.StudentClasses
{
    class RegularStudent : Student, IAssessable
    {
        public override void Display()
        {
            Console.WriteLine("Student Info");
            Console.WriteLine("==============================================");
            DisplayPersonnalInfo();
        }
    }
}