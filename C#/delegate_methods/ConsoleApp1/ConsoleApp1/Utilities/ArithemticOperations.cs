using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utilities
{
    internal class ArithemticOperations
    {
        //public static double Add(int value1, int value2) { return value1 + value2; }

        //public static double Subtract(int value1, int value2) { return value1 - value2; }

        //public static double Multiply(int value1, int value2) { return (value1 * value2); }

        //public static double Divide(int value1, int value2) { return (double)value1 / value2; }

        public static void doOperation(OperationDelegate del)
        {
            Console.WriteLine("Enter Two Numbers ");
            Console.Write("X = "); int x = int.Parse(Console.ReadLine());
            Console.Write("Y = "); int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Doing Operation ...");
            Console.WriteLine($"Answer is {del.Invoke(x, y):f3}");
        }

    }
}
