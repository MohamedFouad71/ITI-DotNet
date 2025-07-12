

// 📝 Task 1: Number Analyzer Program
// Objective:
// Build a simple console application in C# that allows the user to enter a series of numbers, then displays some analysis using variables, conditionals, and loops.
// Instructions:
// 1. Ask the user how many numbers they want to enter.
// 2. Use a `for` loop to allow the user to enter that many numbers.
// 3. Use variables to track the sum, count even and odd numbers, and find the max/min number.
// 4. After all inputs, use `if-else` to display whether most numbers are even or odd.
// 5. Finally, print the sum, average, maximum, and minimum number.
// Sample Output:
// How many numbers will you enter? 5

// Enter number 1: 12
// Enter number 2: 3
// Enter number 3: 7
// Enter number 4: 8
// Enter number 5: 10

// Most of your numbers are even.

// Sum: 40
// Average: 8
// Max: 12
// Min: 3
using System.Globalization;
using Microsoft.VisualBasic;

namespace Lap1
{

    class Program
    {

        static void NumberAnalyser()
        {
            // Could throw an exception if isn't int
            Console.Write("How many numbers will you enter? ");
            int size = int.Parse(Console.ReadLine());


            while (size < 1)
            {
                Console.Write("Value must more than or equal 1\nValue :");
                size = int.Parse(Console.ReadLine());
            }


            long[] nums = new long[size];
            for (int i = 0; i < size; i++)
            {
                // Could throw an exception if isn't int
                Console.Write($"Enter number {i} : ");
                nums[i] = int.Parse(Console.ReadLine());
            }



            long max = nums[0];
            long min = nums[0];
            long sum = 0;
            int evenCount = 0;

            for (int i = 0; i < size; i++)
            {
                sum += nums[i];

                if (nums[i] % 2 == 0) evenCount++;

                if (nums[i] > max) max = nums[i];
                if (nums[i] < min) min = nums[i];
            }

            Console.WriteLine("\n\n\n");
            if (evenCount > (float)size / 2)
                Console.WriteLine("Most of your numbers are even.\n\n\n");

            Console.WriteLine("{0 , -8} | {1 , -30}",$"Sum : " , sum);
            Console.WriteLine("{0 , -8} | {1 , -30}",$"Average : " , (decimal)sum/size);
            Console.WriteLine("{0 , -8} | {1 , -30}",$"Maximim : " , max);
            Console.WriteLine("{0 , -8} | {1 , -30}",$"Minimun : " , min);

        }
        static void Main(string[] arg)
        {
            NumberAnalyser();
        }
    }
}