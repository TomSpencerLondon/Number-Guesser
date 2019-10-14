using System;

namespace NumberGuesser
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // run GetAppInfo
            GetAppInfo();

            // Ask for user's name and greet
            GreetUser();

            while (true)
            {

                // Init Correct Number
                // int correctNumber = 7;

                // create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    // Get user's input
                    string input = Console.ReadLine();

                    // Make sure it is a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number.");

                        continue;
                    }

                    // Cast to int and put to guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number. Please try again.");
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "You are correct. You guessed it.");

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                } else if (answer == "N")
                {
                    return;
                }

                else
                {
                    return;
                }

            }
        }

        // Get and display app info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Tom Spencer";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: version {1} by {2}",
                              appName,
                              appVersion,
                              appAuthor);
            // reset text color
            Console.ResetColor();
        }

        // ask user's name and greet user
        static void GreetUser()
        {
            // Ask user's name
            Console.WriteLine("What is your name?");

            // Get user input

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}. Let's play a game.", inputName);
        }

        // print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user number is wrong
            Console.WriteLine(message);

            // reset text color
            Console.ResetColor();
        }
    }
}
