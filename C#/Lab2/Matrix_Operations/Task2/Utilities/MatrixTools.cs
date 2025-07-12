


using System.Globalization;

namespace Task2.Utilites
{
    class MatrixTools
    {


        public static void Transpose(int[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = i; j < matrix.GetLength(1); j++)
                {
                    Swap(ref matrix[i,j], ref matrix[j,i]);
                }
            }
            

        }


        public static void Print(int[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    System.Console.Write(matrix[i, j] + " ");
                System.Console.WriteLine("");                
            }

        }


        public static int DiaganolSum(int[,] matrix, bool secondaryDiagonal = false)
        {
            int sum = 0;

            if (!secondaryDiagonal)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                    sum += matrix[i, i];
            }
            else
            {
                int row = matrix.GetLength(0) - 1, column = 0;

                while (column < matrix.GetLength(1))
                {
                    sum += matrix[row, column];
                    ++column; --row;
                }
            }

            return sum;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a; a = b; b = temp;
        }
    }
}