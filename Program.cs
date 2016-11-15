using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adverturer Mode:

            //Generate random number an assign it
            Random randNum = new Random();
            var randNum2 = randNum.Next(1, 100);
            var numGuess = 0;
            var userGuess = 0;
            var maxGuesses = 5;
            // Explain Game
            Console.WriteLine("Welcome to my number guessing game!");
            Console.WriteLine();
            Console.WriteLine("You will be required to guess the correct number");
            Console.WriteLine();

            // Initiate Game
            while (numGuess < maxGuesses && userGuess != randNum2)
            {
                Console.WriteLine("Please enter a number between 1 and 100: ");

                var isValid = int.TryParse(Console.ReadLine(), out userGuess);
                ++numGuess;
                
                if (numGuess == maxGuesses)
                {
                    Console.WriteLine("Game Over! You've exceeded your limit"); 
                    Console.WriteLine("The correct number was {0} ", randNum2);
                    Console.ReadLine();
                }
                else if (userGuess == randNum2)
                {
                    Console.WriteLine("Congrats! You guessed correctly");
                    Console.ReadLine();
                }
                else if (userGuess < randNum2)
                {
                    Console.WriteLine("Wrong number too low...Please try again");
                  
                }
                else if (userGuess > randNum2) {
                    Console.WriteLine("Wrong number too high...Please try again");
                   
                }
               
            }

        }



    }


}

