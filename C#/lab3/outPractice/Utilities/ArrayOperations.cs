


using System.Collections.Concurrent;
using System.Numerics;

namespace outPractice.Utilites
{
    class ArrayOperations
    {
        // static int Pratition(int[] arr, int back, int front)
        // {
        //     back--; front++;
        //     int pivot = arr[back + (front - back) / 2];

        //     while (true)
        //     {
        //         do { back++; } while (arr[back] >= pivot); //ascending
        //         do { front--; } while (arr[front] <= pivot);

        //         if (back >= front) return front;

        //         MathOperations.swap(ref arr[back], ref arr[front]);

        //     }


        // }


        // public static void Quicksort(int[] arr, int back, int front)
        // {
        //     int pivotIndex = Pratition(arr, back, front);
        //     Quicksort(arr, back, pivotIndex);
        //     Quicksort(arr, pivotIndex + 1, front);

        // }

        public static void Print(int[] arr)
        {
            foreach (int num in arr)
            {
                System.Console.Write($"{num} ");
            }
            System.Console.WriteLine();

        }

        public static void CalculateArrayStats(int[] scores, out int max, out int min, out double average)
        {

            average = scores.Average();

            min = max = scores[0];
            foreach (int num in scores)
            {
                min = num < min ? num : min;
                max = num > max ? num : max;
            }


        }

        public static void ModifyAndSumArray(ref int[] arr, out int sum)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 5;
            }

            sum = arr.Sum();
        }

        public static void SeparateEvenOdd(int[] input, out int[] evenNumbers, out int[] oddNumbers)
        {
            int evenCount = 0;
            foreach (int num in input)
            {
                if (num % 2 == 0) evenCount++;
            }

            evenNumbers = new int[evenCount];
            oddNumbers = new int[input.Length - evenCount];

            int pe = 0, po = 0;
            foreach (int value in input)
            {
                if (value % 2 == 0) evenNumbers[pe++] = value;
                else oddNumbers[po++] = value;
            }

        }


    }
}