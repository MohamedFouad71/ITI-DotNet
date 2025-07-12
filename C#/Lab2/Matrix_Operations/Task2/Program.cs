using Task2.Utilites;


namespace Task2
{
    class Program
    {
        static void Main()
        {
            #region Input Gazzering

            System.Console.Write("Enter The Dimension N For N * N Matrix : ");

            int size = 0;
            while (!(int.TryParse(Console.ReadLine(), out size)) || size < 0)
            {
                System.Console.Write("Please Enter a valid number : ");
            }


            var matrix = new int[size, size];

            System.Console.WriteLine("Enter The values : \n");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(System.Console.ReadLine());
                }
            }
            #endregion

            #region Operations

            System.Console.WriteLine("Original Matrix : "); MatrixTools.Print(matrix);
            int mainDiagonalSum = MatrixTools.DiaganolSum(matrix);
            int SecDiagonalSum = MatrixTools.DiaganolSum(matrix, true);


            MatrixTools.Transpose(matrix);

            System.Console.WriteLine("Transposed Matrix : "); MatrixTools.Print(matrix);

            System.Console.WriteLine($"\nmain diaginal sum : {mainDiagonalSum}");
            System.Console.WriteLine($"\nSecondary diaginal sum : {SecDiagonalSum}\n");

            
            #endregion
        }
    }
}