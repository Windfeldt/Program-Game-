using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Game_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a number-guessing game.");
            Console.WriteLine("I'm thinking of a number between 1 and 10");
            Console.WriteLine("What is your guess");

            Random random = new Random();

            int answer = random.Next(0, 10);
            int guess;

            do
            {
                string guessString = Console.ReadLine();

                Console.WriteLine("You guessed: " + guessString);

                try
                {
                    guess = int.Parse(guessString);
                }
                catch(Exception e)
                {
                    Console.WriteLine("That's not a number!");
                    Console.WriteLine("The error was: " + e);
                    return;
                }
                if (guess == answer)
                {
                    Console.WriteLine("You are correct!");
                }
                else if (answer > guess)
                {
                    Console.WriteLine("Incorrect! Ny number is lager than your guess");
                }
                else
                {
                    Console.WriteLine("Incorrect! Ny number is small than your guess");
                }
            }
            while (guess != answer);
        }
    }
}
