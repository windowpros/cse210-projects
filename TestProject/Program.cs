using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static Catalog catalog = new Catalog();
    static List<Flight> flights = new List<Flight>();

    static void Main(string[] args)
    {
        int input = 0;

        while (input != 7)
        {
            Console.WriteLine("Welcome Pilot! Select an action:");
            Console.WriteLine("1. Create a Vehicle");
            Console.WriteLine("2. Record flight");
            Console.WriteLine("3. View score");
            Console.WriteLine("4. Display Vehicles");
            Console.WriteLine("5. Load file into the program");
            Console.WriteLine("6. Save Vehicles to a file");
            Console.WriteLine("7. QUIT");

            string selection = Console.ReadLine();

            if (!int.TryParse(selection, out input))
            {
                Console.WriteLine("Invalid selection. Type the number corresponding to the action.");
                continue;
            }

            switch (input)
            {
                case 1:
                    CreateFlyer();
                    break;
                case 2:
                    RecordFlight();
                    break;
                case 3:
                    ViewScore();
                    break;
                case 4:
                    catalog.DisplayFlyers();
                    break;
                case 5:
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    catalog.LoadFromFile(loadFile);
                    break;
                case 6:
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    catalog.SaveToFile(saveFile);
                    break;
                case 7:
                    Console.WriteLine("Closing program... goodnight ZZzz");
                    break;
            }
        }
    }

    static void CreateFlyer()
    {
        Console.Write("Plane or Helicopter? ");
        string type = Console.ReadLine().ToLower();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Horsepower: ");
        int hp = int.Parse(Console.ReadLine());

        Console.Write("Year: ");
        int yr = int.Parse(Console.ReadLine());

        Console.Write("Max Takeoff Weight: ");
        int maxwt = int.Parse(Console.ReadLine());

        if (type == "plane")
        {
            Console.Write("Landing gear (land/sea): ");
            string gear = Console.ReadLine();

            Console.Write("Engine count: ");
            int engines = int.Parse(Console.ReadLine());

            Plane p = new Plane(name, hp, yr, maxwt, gear, engines);
            catalog.AddFlyer(p);
        }
        else if (type == "helicopter")
        {
            Console.Write("Rotor diameter: ");
            int diameter = int.Parse(Console.ReadLine());

            Console.Write("Rotor count: ");
            int rotors = int.Parse(Console.ReadLine());

            Helicopter h = new Helicopter(name, hp, yr, maxwt, diameter, rotors);
            catalog.AddFlyer(h);
        }
    }

    static void RecordFlight()
    {
        var flyers = catalog.GetFlyers();
        for (int i = 0; i < flyers.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {flyers[i].GetModel()}");
        }

        Console.Write("Choose flyer index: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Duration (minutes): ");
        int minutes = int.Parse(Console.ReadLine());

        Flight flight = new Flight(flyers[index], minutes);
        flights.Add(flight);

        Console.WriteLine($"Flight recorded. Points earned: {flight.Points}");
    }

    static void ViewScore()
    {
        int total = 0;
        foreach (var f in flights)
        {
            total += f.Points;
        }
        Console.WriteLine($"Total Points: {total}");
    }
}
