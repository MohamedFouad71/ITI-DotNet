


namespace outPractice.Utilites
{
    class MathOperations
    {
        public static void DivideAndRemainder(int numerator, int denumerator, out int qoutient, out int remainder)
        {
            qoutient = numerator / denumerator;
            remainder = numerator % denumerator;
        }

        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}