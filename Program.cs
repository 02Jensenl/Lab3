using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            bool playAgain = true;
            while (playAgain)
            {
                Console.WriteLine("Welcome to Decision Making!\n");
                Console.WriteLine("What is your name?\n");
                string name = Console.ReadLine();
                Console.WriteLine($"Hello, {name}! Please enter an integer between 1 and 100");
                string input = Console.ReadLine();
                int number = int.Parse(input);

                if (number > 100 || number <= 0)
                {
                    Console.WriteLine($"Hey, {name}! You gotta type in an integer between 1 and 100!");
                }
                else if (number % 2 == 0 && number > 60)
                {
                    Console.WriteLine($"Hey, {name}! {number} is even.");
                }
                else if (number % 2 == 1 && number > 60)
                {
                    Console.WriteLine($"Hey, {name}! {number} is odd.");
                }
                else if (number % 2 == 1)
                {
                    Console.WriteLine($"Hey, {name}! {number} is odd.");
                }
                else if (number % 2 == 0 && number >= 2 && number < 25)
                {
                    Console.WriteLine($"Hey, {name}! Your number is even and less than 25.");
                }
                else if (number % 2 == 0 && number >= 26 && number <= 60)
                {
                    Console.WriteLine($"Hey, {name}! Your number is even.");
                }
                Console.WriteLine($"Wanna play again, {name}? Press any key to continue or x to quit.");
                string userContinue = Console.ReadLine();
                if (userContinue == "x" || userContinue == "X")
                    playAgain = false;

            }
            Console.WriteLine("Thanks for playing!");
        }
    }
}
