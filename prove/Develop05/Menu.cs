using System;

public class Menu
{
    public int DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals to File");
        Console.WriteLine("4. Load Goals From File");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Record Buddy Report");
        Console.WriteLine("7. Display Buddy Reports");
        Console.WriteLine("8. Quit Program");
        Console.Write("Select an option: ");
        return int.Parse(Console.ReadLine());
    }

    public int DisplayGoalCreationMenu()
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select an option: ");
        return int.Parse(Console.ReadLine());
    }
}
