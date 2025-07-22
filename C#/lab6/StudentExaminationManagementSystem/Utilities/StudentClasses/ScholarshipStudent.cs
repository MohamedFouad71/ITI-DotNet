namespace SEMS.Utilities.StudentClasses
{
    class ScholarshipStudent : Student , IAssessable
    {
        int scholarshipAmmount;
        public int ScholarshipAmmount
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException("The Scholarship value must be more than zero");

                scholarshipAmmount = value;
            }
            get => scholarshipAmmount;
        }

        public override void Display()
        {
            Console.WriteLine("Scholarship Student Info");
            Console.WriteLine("==============================================");
            DisplayPersonnalInfo();
            Console.WriteLine($"ScholarShip Ammount : {scholarshipAmmount}");
        }
    }
}