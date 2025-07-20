namespace HRAndPayrollManagementSystem.Classes
{
    class Employee : Person
    {
        #region Fields
        private static readonly Dictionary<uint, string> AllEmployees = [];
        private double baseSalary;
        #endregion

        #region Properties
        public override uint ID
        {
            set
            {
                if (AssignedIDs.Contains(value))
                    throw new ArgumentException("ID already exists.");


                if (AllEmployees.ContainsKey(id))
                {
                    AllEmployees.Remove(id);
                    AssignedIDs.Remove(id);
                }

                id = value;
                AllEmployees[id] = fullName;
                AssignedIDs.Add(id);
            }

            get => id;
        }

        public override string FullName
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Fullname can't be null, or whitespaces.");

                fullName = value;
                AllEmployees[id] = fullName;
            }

            get => fullName;
        }

        public static double TotalPayroll { get; protected set; } = 0;
        public DateTime HireDate { get; set; }

        public double BaseSalary
        {
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary must be positive");

                TotalPayroll -= baseSalary;
                TotalPayroll += value;
                baseSalary = value;
            }

            get => baseSalary;
        }


        #endregion

        #region Constructors
        public Employee()
        {
            AllEmployees[ID] = FullName;
        }
        #endregion

        #region Methods
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Salary      : {BaseSalary} ");
            Console.WriteLine($"Hire Date   : {BaseSalary} ");
        }
        #endregion
    }
}