namespace SEMS.Utilities.StudentClasses
{
    class TransferStudent : Student , IAssessable
    {
        public string PreviousUniversity { set; get; } = "";

        public override void Display()
        {
            Console.WriteLine("Transfer Student Info");
            Console.WriteLine("==============================================");            
            DisplayPersonnalInfo();
            Console.WriteLine($"Previous University : {PreviousUniversity}");
        }
    }
}