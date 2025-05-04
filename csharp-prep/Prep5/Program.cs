using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");


        int finalNumber = GetFavNumber();
        string finalName = GetUserName();
        int finalSqr = aFinalSquare(finalNumber);
        // int finalSqr = finalNumber * finalNumber;

        FinalText(finalName,finalSqr);

        // Console.WriteLine($"Hi {finalName}, your favorite number squared is {finalSqr}");

        static string GetUserName()
        {
            Console.WriteLine("What is your UserName? ");
            string UserName = Console.ReadLine();
            return UserName;
        }

        static int GetFavNumber()
        {
            Console.WriteLine("What is your favorite Number? ");
            string FavNumber = Console.ReadLine();
            int aFavNumber = int.Parse(FavNumber);
            return aFavNumber;
        }
        static int aFinalSquare(int finalNumber)
        {
            int testFinalSquare = finalNumber * finalNumber;
            return testFinalSquare;
        }

       static void FinalText(string finalName, int finalSqr)
       {
        Console.WriteLine($"Welcome, {finalName}, your favorite number Squared is {finalSqr}");
       }

    }

}