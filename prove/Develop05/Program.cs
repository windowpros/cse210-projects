using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        bool running = true;

        while (running)
        {
            int choice = menu.DisplayMenu();

            switch (choice)
            {
                case 1:
                    int CreateGoalChoice = 0;
                    CreateGoalChoice = menu.DisplayGoalCreationMenu();
                    switch (CreateGoalChoice)
                    {
                        case 1:
                            SimpleGoal MySimpleGoal = new SimpleGoal();
                            MySimpleGoal.DisplayGoal();


                    }
                    break;
                case 2:
                    Console.WriteLine("Listing goals...");
                    break;
                case 3:
                    Console.WriteLine("Saving goals...");
                    break;
                case 4:
                    Console.WriteLine("Loading goals...");
                    break;
                case 5:
                    Console.WriteLine("Recording event...");
                    break;
                case 6:
                    Console.WriteLine("Recording buddy report...");
                    break;
                case 7:
                    Console.WriteLine("Displaying buddy reports...");
                    break;
                case 8:
                    Console.WriteLine("Quitting program. Goodbye!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Unknown option.");
                    break;
            }
        }

    }

}