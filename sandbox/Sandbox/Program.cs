using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Console.WriteLine("Input your first name: ");
        string firstname = Console.ReadLine();
        Console.WriteLine($"Your first name is: {firstname}");

        Console.WriteLine("Input your last name: ");
        string lastname = Console.ReadLine();
        Console.WriteLine($"Your full name is: {lastname}, {firstname}");

    }
}