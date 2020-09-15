using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***************************************************************
* Name        : Random Number Guessing Game - pg. 339 #11
* Author      : Kabrina Brady
* Created     : 9/23/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : User tries to guess randomly generated number between 1 and 100
*               Input:  Number that user guesses
*               Output: Text from program
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/


namespace RandomNumberGuessBrady
{
    class RandomNumberGuessingGameProgram
    {
        static void Main(string[] args)
        {
            double userGuess = 0; //the number the user guesses
            int numTries = 1; //counts number of times user has guessed

            Random randomGenerator = new Random(); //generates random number
            int randNum = randomGenerator.Next(1, 100); //assigns the random number to an int variable and only generates numbers up to 100

            while (userGuess != randNum) //executes while user's guess is not the correct answer
            {
                try
                {
                    Console.WriteLine("Guess a number between 1-100."); //asks user to enter a temp
                    userGuess = double.Parse(Console.ReadLine()); //converts string to double
                    if (userGuess == randNum) //executes if user guesses the right number
                    {
                        Console.WriteLine("Congratulations! You guessed the number! Play again? Press 1 for yes, 0 for no.");
                        string playAgain = Console.ReadLine(); //reads user input
                        if (playAgain == "1") //executes loop again if user wants to play again
                        {
                            randNum = randomGenerator.Next(1, 100); //resets random number generator
                            numTries = 1; //resets numTries
                        }
                        else
                        {
                            Environment.Exit(0); //terminates the program
                        }
                    }
                    Console.WriteLine("Number of tries: " + numTries++); //prints number of tries
                    
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number. Try again."); //ensures user input is number
                }
            }
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine(); //reads user input
        }
    }
}
