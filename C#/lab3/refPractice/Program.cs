


using System.Diagnostics.Contracts;
using System.Globalization;
using refPractice.Utilities;

namespace refPractice
{
    class Program
    {
        static void Main()
        {
            #region Add Bonus
            System.Console.WriteLine("What is your monthly salary? ");
            double salary;

            while (!double.TryParse(Console.ReadLine(), out salary) || salary < 0)
            {
                System.Console.WriteLine("[Error] Salary Can not be negative");
                System.Console.WriteLine("What is your monthly salary? ");
            }

            SalaryManager.AddBonus(ref salary);

            System.Console.WriteLine($"Your current Salary After bonus is {salary:c2}");

            #endregion

            #region Swap
            System.Console.WriteLine("Enter Two nums ");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"Before Swap a , b => {a} , {b}");
            MathOperations.Swap(ref a, ref b);
            System.Console.WriteLine($"After Swap a , b => {a} , {b}");

            #endregion

            System.Console.WriteLine("Enter the arr size");
            int size = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the array elements");

            var nums = new int[size];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Before Reverse");
            ArrayOperations.Print(nums);

            ArrayOperations.Reverse(nums);
            System.Console.WriteLine("After Reverse");
            ArrayOperations.Print(nums);
        }
    }
}