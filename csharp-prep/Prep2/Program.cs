using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What grade did you receive? ");
        string grade = Console.ReadLine();
        int numberGrade = int.Parse(grade);

        string letterGrade = "";

        if (numberGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (numberGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (numberGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (numberGrade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (letterGrade != "F")
        {
            Console.WriteLine($"Great you passed the class with {letterGrade}");

        }
        else
        {
            Console.WriteLine("You failed this course, but you can try again for a better grade");
        }
    }
}