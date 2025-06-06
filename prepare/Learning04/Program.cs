using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment a1 = new Assignment("Camden Hendricks", "Algebra");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Samuel Davidson", "Fractions", "14-A", "1-5");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Donald Trunp", "Art", "How to be like Davinci");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());

    }
}