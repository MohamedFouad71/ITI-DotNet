
namespace Sorting_algorithm.UTILITIES
{
    class PrintArray
    {
        public static void Print(int[] arr)
        {
            System.Console.Write("[ ");
            foreach (int num in arr)
                System.Console.Write($"{num} ");

            System.Console.WriteLine("]");
        }
    }
}