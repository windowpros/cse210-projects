using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using System.Security.Claims;

public class Job
{
    public string _title;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void DisplayJob()
    {
        Console.WriteLine(_title.ToUpper());
        Console.WriteLine($"({_company})");
        Console.WriteLine($"Start: {_startYear}");
        Console.WriteLine($"End: {_endYear}");
    }
}

public class Resume
{
    public string _person;
    public List<Job> _careerList = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine(_person);
        foreach (Job J in _careerList)
        {
            J.DisplayJob();
        }
    }
}