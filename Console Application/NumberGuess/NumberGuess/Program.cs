using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess
{
    class Program
    {
        /// <summary>
        /// Random number generator
        /// </summary>
        /// <returns>Number after randomization</returns>
        private static int RandomizeNumber()
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(1, 11); // Random number between 1 and 10

            return randomNum;
        }

        /// <summary>
        /// Determine if the input number and the generated number are identical.
        /// Will return false if otherwise.
        /// </summary>
        /// <param name="inputNumber">Number from user input</param>
        /// <param name="actualNumber">Number from random number generator</param>
        /// <returns>Boolean value to determine if 2 numbers are matched</returns>
        private static Boolean NumberMatch(int inputNumber, int actualNumber)
        {
            Boolean areNumbersMatched = false;

            // Assign areNumbersMatched to true if 2 numbers are identical
            // Leave areNumbersMatched as false if otherwrise
            if (inputNumber == actualNumber)
            {
                areNumbersMatched = true;
            }

            return areNumbersMatched;
        }

        static void Main(string[] args)
        {
            int randomNumber = RandomizeNumber(); // Number from random number generator
            int guessAttempts = 3; // Number of guess attempts

            // Introduction for the number guessing game
            Console.WriteLine("C# Random Number Generator");
            Console.WriteLine("Guess a number between 1 and 10");
            Console.WriteLine("You have " + guessAttempts + " guesses");
            Console.WriteLine();

            // Game mechanics
            // Game will stop if guessAttempts reaches to 0 or number has been guessed correctly
            while (guessAttempts > 0)
            {
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine()); // User input is converted to integer

                    // Fail message if input number does not match with actual number
                    if (!NumberMatch(input, randomNumber))
                    {
                        guessAttempts--; // Deduct guessAttempts when user enters incorrect number
                        Console.WriteLine(input + " is incorrect. You have " + guessAttempts + " guesses left."); // Show remaining number of guess attempts after deduction
                        Console.WriteLine();

                        // Continue the loop while guessAttempts does not reach to 0
                        if (guessAttempts > 0)
                        {
                            continue; // While loop will not stop until guessAttempts reaches to 0
                        }
                        // Stop the game if guessAttempts reaches to 0
                        else
                        {
                            Console.WriteLine("You lost the game. Actual number is " + randomNumber + ". Press the Enter key to close."); // Show the actual number to the user after game is over
                            Console.ReadLine();
                        }
                    }

                    // Success message if input number matches with actual number
                    else
                    {
                        Console.WriteLine("Success! Press the Enter key to close.");
                        Console.ReadLine();
                        break; // Stop the while loop after successful guess
                    }
                }
                // Error message if input is invalid
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a numeric input.");
                    continue; // Continue the while loop despite invalid input
                }
            }
        }
    }
}
