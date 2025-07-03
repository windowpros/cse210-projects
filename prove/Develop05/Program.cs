using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        GoalManager manager = new GoalManager();
        bool running = true;

        BuddyReport MyBuddyReport = new BuddyReport();

        while (running)
        {
            int choice = menu.DisplayMenu();

            switch (choice)
            {
                case 1:
                    int createChoice = menu.DisplayGoalCreationMenu();
                    switch (createChoice)
                    {
                        case 1:
                            Console.Write("Enter name: ");
                            string sName = Console.ReadLine();
                            Console.Write("Enter description: ");
                            string sDesc = Console.ReadLine();
                            Console.Write("Enter points: ");
                            int sPoints = int.Parse(Console.ReadLine());

                            SimpleGoal sg = new SimpleGoal(sName, sDesc, sPoints);
                            manager.AddGoal(sg);
                            break;

                        case 2:
                            Console.Write("Enter name: ");
                            string eName = Console.ReadLine();
                            Console.Write("Enter description: ");
                            string eDesc = Console.ReadLine();
                            Console.Write("Enter points: ");
                            int ePoints = int.Parse(Console.ReadLine());

                            EternalGoal eg = new EternalGoal(eName, eDesc, ePoints);
                            manager.AddGoal(eg);
                            break;

                        case 3:
                            Console.Write("Enter name: ");
                            string cName = Console.ReadLine();
                            Console.Write("Enter description: ");
                            string cDesc = Console.ReadLine();
                            Console.Write("Enter points per record: ");
                            int cPoints = int.Parse(Console.ReadLine());
                            Console.Write("Enter target count: ");
                            int target = int.Parse(Console.ReadLine());
                            Console.Write("Enter bonus points on completion: ");
                            int bonus = int.Parse(Console.ReadLine());

                            ChecklistGoal cg = new ChecklistGoal(cName, cDesc, cPoints, target, bonus);
                            manager.AddGoal(cg);
                            break;

                        default:
                            Console.WriteLine("Invalid goal type.");
                            break;
                    }
                    break;

                case 2:
                    manager.DisplayGoals();
                    break;

                case 3:
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    manager.SaveGoals(saveFile);
                    break;

                case 4:
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    manager.LoadGoals(loadFile);
                    break;

                case 5:
                    manager.DisplayGoals();
                    Console.Write("Which goal did you accomplish? Enter number: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(index);
                    break;

                case 6:
                    MyBuddyReport.GetName();
                    MyBuddyReport.GetConversation();
                    MyBuddyReport.CreateReport();
                    MyBuddyReport.AddReportToList();
                    break;

                case 7:
                    MyBuddyReport.DisplayAllReports();
                    break;

                case 8:
                    Console.WriteLine("Quitting program. Goodbye!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Unknown option.");
                    break;
            }

            manager.DisplayScore();
            Console.WriteLine();
        }
    }
}
