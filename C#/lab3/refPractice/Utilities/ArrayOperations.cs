


namespace refPractice.Utilities
{
    class ArrayOperations
    {
        public static void Reverse(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                MathOperations.Swap(ref arr[i], ref arr[arr.Length - 1 - i]);
            }
        }

        public static void Print(int[] nums)
        {
            foreach (int num in nums)
            {
                System.Console.Write(num + " ");
            }
            System.Console.WriteLine();
        }


    }
}