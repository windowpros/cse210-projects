using System;
using System.Collections.Generic;
using System.Threading;

public class Writing : Activity
{
    private List<string> _prompts = new List<string> {
        "Who are some people that you appreciate from this week?",
        "How did you use your gifts and talents to bless others this week?",
        "Who have you helped today?",
        "What is something you can do to improve?",
        "What are a couple of your goals?"
    };

    public Writing() : base("Listing", "You now have a chance to think and write about the different experiences of your day or week.") {}

    public override void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        Console.Write("You may begin listing in: ");
        Countdown(5);

        int count = 0;
        DateTime end = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items :)");
        End();
    }
}