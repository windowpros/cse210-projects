using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction firstFraction = new Fraction(3, 4);
        Console.WriteLine(firstFraction.GetFractionDecimal());
        Console.WriteLine(firstFraction.GetFractionString());

    }
}