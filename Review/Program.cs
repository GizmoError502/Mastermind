using System;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MasterMind!");
            Console.WriteLine("\nA new 4 digit code has been made:");
            Console.WriteLine(" - Each digit falls between 1 and 6, at random.");
            Console.WriteLine(" - There are only 4 digits total.");
            Console.WriteLine("You have up to 10 tries to guess the correct number.");
            Console.WriteLine("After each guess, I will give you a 4-digit response:");
            Console.WriteLine(" - A '+' character means your guess was correct in that position.");
            Console.WriteLine(" - A '-' character means that digit is in the code, but not in that position.");
            Console.WriteLine(" - A ' ' means that digit is not in the code at all.");
            Console.WriteLine("\nPlease enter your first guess now.");

            var game = new Game();

            do
            {
                Console.Write("\n> ");
                var guess = Console.ReadLine();

                Console.WriteLine(game.Guess(guess));

            } while (!game.IsFinished);
        }
    }
}