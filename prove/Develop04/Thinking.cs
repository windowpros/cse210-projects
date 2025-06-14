using System;
using System.Threading;
using System.Collections.Generic;

public class Thinking : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you felt guided by the spirit.",
        "Think of a time when you listened to a prompting. How did you feel?",
        "Think of a time when you made a sacrifice.",
        "Think about why you are who you are today."
    };

    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
    };

    public Thinking() : base("Reflection", "This activity is designed to help you ponder the experiences of your life and how you have been a blessing to others.") {}

    public override void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("Reflect on the following questions:");

        DateTime end = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < end)
        {
            Console.WriteLine("\n" + _questions[rand.Next(_questions.Count)]);
            ShowSpinner(5);
        }
        End();
    }
}