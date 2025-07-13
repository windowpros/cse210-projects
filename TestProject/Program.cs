using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hallo weld");

        int input = 0;

        while (input != 7)
        {
            Console.WriteLine("Welcome Pilot! Select an action:");
            Console.WriteLine();
            Console.WriteLine("1. Create a Vehicle");
            Console.WriteLine("2. Record flight");
            Console.WriteLine("3. View score");
            Console.WriteLine("4. Display Vehicles");
            Console.WriteLine("5. Load file into the program");
            Console.WriteLine("6. Save Vehicles to a file");
            Console.WriteLine("7. QUIT");

            string selection = Console.ReadLine()!;  // i added the "null operator" to accept values that are not anyhting.

            if (!int.TryParse(selection, out input))
            {
                Console.WriteLine("Invalid selection. Type the number corresponding to the action.");
                continue;
            }

            switch (input)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    Console.WriteLine("Closing program... goodnight ZZzz");
                    break;

            }

        }


    }
}