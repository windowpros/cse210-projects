using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        Console.WriteLine("Add numbers to the list. When finished, type 0. ");
        string contribution = Console.ReadLine();
        int aContribution = int.Parse(contribution);

        int maximum = 0;

        while (true)
        {
            Console.WriteLine("Add another number. ");
            contribution = Console.ReadLine();
            aContribution = int.Parse(contribution);

            if (aContribution != 0)
            {
                numbers.Add(aContribution);
            }
            else
            {
                break;
            }
        }

        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

       
        int average = sum/numbers.Count;
        

        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine($"Average = {average}");
        Console.WriteLine($"Maximum = {maximum}");
    }
}