using System;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Claims;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job testJob = new Job();
        testJob._title = "Analyst";
        testJob._company = "McKinsey & Co.";
        testJob._startYear = 2025;
        testJob._endYear = 2028;

        Job job2 = new Job();
        job2._title = "Chief Executive Officer";
        job2._company = "Window Pros";
        job2._startYear = 2024;
        job2._endYear = 2025;

        Resume testResume = new Resume();
        testResume._person = "Camden Hendricks";
        testResume._careerList.Add(testJob);
        testResume._careerList.Add(job2);

        testResume.DisplayResume();  // Calls a method in the Resume class that displays the data for given Resume (testResume)

        // Console.WriteLine(testResume._person);
        // Console.WriteLine(testResume._career);

        // Console.WriteLine(testJob._title);
        // Console.WriteLine(testJob._company);
        // Console.WriteLine(testJob._startYear);
        // Console.WriteLine(testJob._endYear);
    }
}