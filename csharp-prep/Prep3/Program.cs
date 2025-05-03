using System;
using System.Collections;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        // Console.WriteLine("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int secretNumber = int.Parse(magicNumber);

        Random randomGenerator = new Random();
        int secretNumber = randomGenerator.Next(1,100);

    
        int aGuess = 0;


        while (aGuess != secretNumber)
        {
            Console.WriteLine("Guess the secret number?");
            String guess = Console.ReadLine();
            aGuess = int.Parse(guess);
            
            if (aGuess < secretNumber)
            {
                Console.WriteLine("You need to guess a higher number.");
            }
            else
            {
                Console.WriteLine("You need to guess a lower number. ");
            }
        }
        
         Console.WriteLine("Congrats, you guessed the secret number!");

    }
}