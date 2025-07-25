

using ConsoleApp1.Utilities;

namespace ConsoleApp1
{
    public delegate double OperationDelegate(int value1, int value2);
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                try
                {


                    Console.WriteLine("========================================================");
                    Console.WriteLine("                 Arithmetic Operations                ");
                    Console.WriteLine("========================================================");
                    Console.WriteLine("Enter your Choice : ");
                    Console.WriteLine("1. ADD x , y");
                    Console.WriteLine("2. Sub x , y");
                    Console.WriteLine("3. Divide x , y");
                    Console.WriteLine("4. Multiply x , y");
                    Console.WriteLine("5. exit");
                    Console.WriteLine("Enter your choice");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 5)
                    {
                        Console.WriteLine("Exiting");
                        Environment.Exit(0);
                    }

                    switch (choice)
                    {
                        case 1:
                            ArithemticOperations.doOperation((x, y) => x + y);
                            break;
                        case 2:
                            ArithemticOperations.doOperation((x, y) => x - y);
                            break;
                        case 3:
                            ArithemticOperations.doOperation((x, y) => (double)x / y);
                            break;
                        case 4:
                            ArithemticOperations.doOperation((x, y) => x * y);
                            break;
                        default:
                            throw new Exception("choice should be an integer from 1 to 5");
                    }


                }
                catch (Exception e) { Console.WriteLine(e.Message); }



            }
        }
    }
}
