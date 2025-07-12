


namespace refPractice.Utilities
{
    class MathOperations
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}