namespace SEMS.Utilities.StudentClasses
{
    class GraduateStudent:Student , IAssessable
    {
        public string ThesisTitle { get; set; } = "";
        public string AdvisorName { get; set; } = "";

        public override void Display()
        {
            Console.WriteLine("Graduate Student Info");
            Console.WriteLine("==============================================");
            DisplayPersonnalInfo();
            Console.WriteLine($"Thesis Title : {ThesisTitle}");
            Console.WriteLine($"Advisor Name : {AdvisorName}");
        }
    }
}