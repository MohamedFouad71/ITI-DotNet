using System.Linq.Expressions;
using HRAndPayrollManagementSystem.Classes;


namespace HRAndPayrollManagementSystem
{
    class Program
    {
        static public void Main(string[] args)
        {
            Manager[] managers =
            {
                new (){ID = 1 , BaseSalary = 1000, FullName= "ahemd Ali", Bonus = 50, HireDate =new(2023,7,1)},
                new (){ID = 32 , BaseSalary = 1500, FullName= "Ali moaz", Bonus = 0, HireDate =new(2020,8,1)},
                new (){ID = 12 , BaseSalary = 1231, FullName= "Rahma Sayed", Bonus = 100, HireDate =new(2010,3,2)},
                new (){ID = 14 , BaseSalary = 6231, FullName= "Mazen Ali", Bonus = 102, HireDate =new(2013,3,4)},
            };

            Employee[] employees =
            {
                new (){ID = 2 , BaseSalary = 1000, FullName= "Mohamed Mahmoud", HireDate =new(2013,2,1)},
                new (){ID = 3 , BaseSalary = 1000, FullName= "Mohamed sayed", HireDate =new(2021,4,1)},
                new (){ID = 4 , BaseSalary = 1000, FullName= "ahmed ramy", HireDate =new(2009,5,1)},
            };

            foreach (Employee e in employees)
                managers.ElementAt(0).AddTeamMember(e);
            

            
            foreach (Person P in managers.Concat(employees))
            {
                if (P is Manager)
                    Console.WriteLine("Manager Details");
                else
                    Console.WriteLine("Employee Details");

                P.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}