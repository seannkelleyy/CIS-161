/* Sean Kelley
 * CIS-161
 * 13 February 2022
 * Chapter 4 Lab 2
 */

using System;
using static System.Console;
class game
{
    static void Main()
    {
        WriteLine("Your choices are rock (r), paper (p) or scissors (s).");
        WriteLine("Player enter your choice!");
        char playerChoice = ReadLine()[0];

        Random randomNumberGenerator = new Random();
        int randomNumber = randomNumberGenerator.Next(1, 4);

        if (randomNumber == 1)
        {
            if (playerChoice == 'r')
            {
                Console.WriteLine("The computer chose rock");
                Console.WriteLine("Tie");
            }
            else if (playerChoice == 'p')
            {
                Console.WriteLine("The computer chose rock");
                Console.WriteLine("You win!");
            }
            else if (playerChoice == 's')
            {
                Console.WriteLine("The computer chose rock");
                Console.WriteLine("You lose!");
            }
        }
        else if (randomNumber == 2)
        {
            if (playerChoice == 'p')
            {
                Console.WriteLine("The computer chose paper");
                Console.WriteLine("Tie");
            }
            else if (playerChoice == 'r')
            {
                Console.WriteLine("The computer chose paper");
                Console.WriteLine("You lose!");
            }
            else if (playerChoice == 's')
            {
                Console.WriteLine("The computer chose paper");
                Console.WriteLine("You win!");
            }
        }
        else if (randomNumber == 3)
        {
            if (playerChoice == 's')
            {
                Console.WriteLine("The computer chose scissors");
                Console.WriteLine("Tie");
            }
            else if (playerChoice == 'p')
            {
                Console.WriteLine("The computer chose scissors");
                Console.WriteLine("You lose!");
            }
            else if (playerChoice == 'r')
            {
                Console.WriteLine("The computer chose scissors");
                Console.WriteLine("You win!");
            }
        
        }

    }
}
