// using Sorting_algorithm.UTILITIES;
// class Test
// {
//     static void Main()
//     {

//         #region Sort Test
//         int[] numbers = { 5, 1, 9, 3, 7, 2, 8 };

//         Console.ForegroundColor = ConsoleColor.Yellow;
//         Console.WriteLine("Original Array:");
//         PrintArray.Print(numbers);

//         // Call QuickSort
//         Sort.Quicksort(numbers, 0, numbers.Length - 1);

//         Console.ForegroundColor = ConsoleColor.Green;
//         Console.WriteLine("\nSorted Array (Descending):");
//         PrintArray.Print(numbers);

//         Console.ResetColor();

//         #endregion


//         #region Prime Test
//         Console.ForegroundColor = ConsoleColor.Yellow;
//         Console.Write("Enter a number to check if it's prime: ");
//         Console.ResetColor();

//         if (long.TryParse(Console.ReadLine(), out long number))
//         {
//             bool result = Prime.IsPrime(number);

//             if (result)
//             {
//                 Console.ForegroundColor = ConsoleColor.Green;
//                 Console.WriteLine($"{number} is a prime number.");
//             }
//             else
//             {
//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.WriteLine($"{number} is not a prime number.");
//             }
//         }
//         else
//         {
//             Console.ForegroundColor = ConsoleColor.Red;
//             Console.WriteLine("Invalid input. Please enter a valid integer.");
//         }

//         Console.ResetColor();

        
//         #endregion
//     }
    
// }
