using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice.Utilities
{
    internal class PrintEnumerable
    {
        static public void Print<T>(IEnumerable<T> enumerable)
        {
            foreach (var item in enumerable)
            {
                // Set a different color for each item
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(item);
            }

            // Reset the console color back to default after printing
            Console.ResetColor();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Done Printing ...");
        }
    }
}
