// Objective:
// Create a console application that simulates a simple ATM using variables, conditions, and loops.
// Instructions:
// 1. Start with a balance (e.g., 1000).
// 2. Show a menu with 3 options:
//    a) Check Balance
// bo   b) Deposit Money
//    c) Withdraw Money
//    d) Exit
// 3. Use a loop to keep showing the menu until the user chooses to exit.
// 4. Use if-else statements to handle each option.
// 5. Make sure to prevent withdrawing more than the current balance.
// Sample Output:
// Welcome to the ATM!

// 1. Check Balance
// 2. Deposit
// 3. i
// 4. Exit

// Choose an option: 2
// Enter amount to deposit: 500

// Balance is now: 1500


namespace Program
{ 
    class Program
    {
        static void Main(string[] args)
        {
            float balance = 1000f;
            bool isRunning = true;

            while (isRunning)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nChoose an option");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposite");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Choice : ");
                Console.ResetColor();

                if (short.TryParse(Console.ReadLine(), out short choice))
                {

                    Console.Clear();
                    switch (choice)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Current Balance : {balance:C2}");
                            Console.ResetColor();
                            break;

                        case 2:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Amount : ");
                            if (float.TryParse(Console.ReadLine(), out float amount) && amount > 0)
                            {
                                balance += amount;
                                goto case 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Entry");
                                Console.ResetColor();
                                break;
                            }

                        case 3:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Amount : ");
                            if (float.TryParse(Console.ReadLine(), out float value) && value <= balance)
                            {
                                balance -= value;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Successfull");
                                goto case 1;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Entry");
                                Console.ResetColor();
                                break;
                            }

                        case 4:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Exiting ...");
                            Console.ResetColor();
                            isRunning = false;
                            break;
                    }


                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Option");
                    Console.ResetColor();
                }





            }
        }
    }
}