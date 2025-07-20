namespace HRAndPayrollManagementSystem.Classes
{
    class Manager : Employee
    {
        #region Properties and Fields
        double bonus;

        public double Bonus
        {
            set
            {
                if (value < 0)
                    throw new ArgumentException("Bonus Must Be Positive");

                bonus = value;
            }

            get => bonus;
        }

        public HashSet<Employee> TeamMembers { set; get; } = [];

        #endregion

        #region Methods
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Bonus       : {Bonus} ");
            Console.WriteLine($"Total Salary: {GetTotalSalary()} ");

            Console.WriteLine($"Team Members:\n");
            GetTeamMembers();
            Console.WriteLine();
        }
        public double GetTotalSalary()
        {
            return BaseSalary + Bonus;
        }

        public void GetTeamMembers()
        {
            foreach (Employee member in TeamMembers)
                Console.WriteLine($"{member.FullName}");
        }

        #endregion

        #region OperatorOverloading

        public static Manager operator +(Manager right, Manager left)
        {
            Random r = new();

            return new Manager()
            {
                id = right.id,
                FullName = right.FullName + " And " + left.FullName,
                BaseSalary = right.BaseSalary + left.BaseSalary,
                Bonus = right.bonus + left.Bonus,
                TeamMembers = [.. right.TeamMembers.Concat(left.TeamMembers)]
            };
        }

        public void AddTeamMember(Employee E)
        {
            if (TeamMembers.Contains(E))
                Console.WriteLine("Member already Exists");
            else
                TeamMembers.Add(E);
        }
        #endregion
    }
}