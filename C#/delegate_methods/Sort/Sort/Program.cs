namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] arr = { 123, 31, 4142, 642, 7432, 256, 73, 1, 9097, 1246, 43, 87, 10, 3 };

            Print.Array(arr);

            Sorter.SortEnumerable(arr, Sorter.SortDescending);

            Print.Array(arr);
        }
    }
}
