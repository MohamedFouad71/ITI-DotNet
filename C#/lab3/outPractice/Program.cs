


using outPractice.Utilites;

namespace outPractice
{
    class Program
    {
        static void Main()
        {
            // #region Remainder and Qoutient
            // System.Console.WriteLine("Enter Two integers ");
            // int numerator = int.Parse(Console.ReadLine());
            // int denumerator = int.Parse(Console.ReadLine());

            // int qoutient = -1, remainder = -1;
            // MathOperations.DivideAndRemainder(numerator: numerator, denumerator: denumerator, out qoutient, out remainder);

            // System.Console.WriteLine($"q = {qoutient}, r = {remainder}");
            // #endregion

            // #region Student status

            // System.Console.WriteLine("Enter student name : ");

            // string name = Console.ReadLine();
            // int age;
            // double grade;

            // StudentInfo.GetStudentInfo(name, out age, out grade);

            // System.Console.WriteLine($"name = {name}\nAge = {age}\nGrade = {grade:f2}");

            // #endregion




            #region Array Statistics

            System.Console.WriteLine("Enter the array size");
            int size = int.Parse(Console.ReadLine());

            var arr = new int[size];

            System.Console.WriteLine("Enter The Values : ");

            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write($"value {i} : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Arr vals :");
            ArrayOperations.Print(arr);

            int max, min;
            double avg;
            ArrayOperations.CalculateArrayStats(arr, out max, out min, out avg);

            System.Console.WriteLine($"max : {max}\nmin : {min}\nAvg : {avg:f2}");

            #endregion

            #region Mod array with out and ref

            int sum;
            ArrayOperations.ModifyAndSumArray(ref arr, out sum);

            System.Console.Write("new arr :");
            ArrayOperations.Print(arr);

            System.Console.WriteLine($"Sum : {sum}");
            #endregion

            #region Even Odd Sepation

            int[] even;
            int[] odd;

            ArrayOperations.SeparateEvenOdd(arr, out even, out odd);

            System.Console.Write("Even : ");
            ArrayOperations.Print(even);

            System.Console.Write("Odd : ");
            ArrayOperations.Print(odd);
                
            #endregion
        }
    }
}