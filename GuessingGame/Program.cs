using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a number between 1 and 10.");  //Asks the user to input a number
            string userGuess = Console.ReadLine();            //Waits for the user to input a number
            Console.WriteLine("You guessed: " + userGuess);   //Concatenates You guessed with user input

            if (userGuess.Equals("7"))   //If input is 7 they win
            {
                Console.WriteLine("You win!");
            }

            else
            {
                Console.WriteLine("You lost");  //If input is anything other than 7 they lose
            }

        }
    }
}
