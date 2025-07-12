using Sorting_algorithm.UTILITIES;

namespace Sorting_algorithm
{
    class Program
    {
        static void Main()
        {

            #region Input Gazzering

            int size = 0;
            System.Console.Write("Enter The Number Of Elements in The array : ");

            while (!(int.TryParse(Console.ReadLine(), out size)) || size <= 0)
                System.Console.Write("Please Enter a valid value : ");


            int[] nums = new int[size];


            //Input Gazzering
            for (int i = 0; i < nums.Length; i++)
            {
                System.Console.Write($"Number {i + 1} = ");

                while (!(int.TryParse(Console.ReadLine(), out nums[i])))
                    System.Console.Write("Please Enter a valid value : ");
            }

            #endregion



            #region Sorting

            System.Console.WriteLine("Original Array : "); PrintArray.Print(nums);

            Sort.Quicksort(nums, 0, nums.Length - 1);// Sorting

            System.Console.WriteLine("Sorted Array : "); PrintArray.Print(nums);

            #endregion



            #region Prime 

            Prime.PrintPrimes(nums);
            System.Console.Write($"Primes Sum : {Prime.Sum(nums)}");
            
            #endregion

        }




    }
}