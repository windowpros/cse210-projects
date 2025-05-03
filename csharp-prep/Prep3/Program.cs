using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        int secretNumber = int.Parse(magicNumber);

    
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