

namespace Sorting_algorithm.UTILITIES
{
    class Prime
    {
        public static bool IsPrime(long n)
        {

            if (n == 2) return true;
            if (n <= 1) return false;
            if (n % 2 == 0) return false;

            int boundary = (int)Math.Sqrt(n);

            for (int i = 3; i <= boundary; i += 2) // O(sqrt(n))
                if ((n % i) == 0)
                    return false;

            return true;
        }


        public static void PrintPrimes(int[] arr)
        {
            System.Console.WriteLine("Printing Primes ...");


            System.Console.Write("[ ");

            foreach (int num in arr)
                if (IsPrime(num))
                    System.Console.Write($"{num} ");

            System.Console.WriteLine("]");
        }


        public static int Sum(int[] arr)
        {
            int sum = 0;

            foreach (int num in arr)
                if (IsPrime(num))
                    sum += num;

            return sum;
        }
    }
}