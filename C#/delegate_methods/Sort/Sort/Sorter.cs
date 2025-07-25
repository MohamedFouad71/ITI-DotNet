using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{

    internal static class Sorter
    {
        public static void SortEnumerable(int[] arr, Action<int[]> SortStrategy)
        {
            Console.WriteLine("Sorting ...");
            SortStrategy.Invoke(arr);
            Console.WriteLine("Successfull! , Sorted Enumerable : ");
            Print.Array(arr);
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void SortDescending(int[] arr)
        {
            if (arr.Length == 0)
                Console.WriteLine("Array is Empty");

            int i = -1, j = -1;

            try
            {
                for (i = 0; i < arr.Length - 1; i++)
                {
                    int minIndex = arr.Length - 1 - i;

                    for (j = i; j < arr.Length - i; j++)
                        if (arr[j] < arr[minIndex]) minIndex = j;

                    Swap(ref arr[minIndex], ref arr[arr.Length - i - 1]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Caught at i , j  =  {i} , {j}");
            }


        }

        public static void SortAscending(int[] arr)
        {
            int MaxIndex = arr.Length - 1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i; j < arr.Length; j++)
                    if (arr[j] > arr[MaxIndex]) MaxIndex = j;

                Swap(ref arr[MaxIndex],ref arr[arr.Length - i]);
            }
        }

        public static void EvenFirstAscendingSort(int[] arr)
        {
            SortAscending(arr);

            int LastEvenIndex = -1;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 == 0) Swap(ref arr[i], ref arr[++LastEvenIndex]);
        }

    }
}
