using System;
using System.Threading;

public class Breathing : Activity
{
    public Breathing() : base("Breathing", "This Activity will help you to get into the zen and find peace while breathing calmly. Allow your mind to let go of its worries.") {}

    public override void Run()
    {
        Start();
        int interval = 4;
        for (int i = 0; i < Duration; i += interval * 2)
        {
            Console.Write("\nBreathe in...");
            Countdown(interval);
            Console.Write("\nBreathe out...");
            Countdown(interval);
        }
        End();
    }
}