using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Journal myJournal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("=== Journal Menu ===");
            Console.WriteLine("Type one of the following numbers to select an option:");
            Console.WriteLine("1. Write a new entry. ");
            Console.WriteLine("2. Display my entries. ");
            Console.WriteLine("3. Save to a file. ");
            Console.WriteLine("4. Load from a file. ");
            Console.WriteLine("5. Quit");
            string _choice = Console.ReadLine();
            

            switch (_choice)
            {
                case "1":
                    Entry newEntry = new Entry();
                    newEntry.CreateNewEntry();
                    myJournal._allEntries.Add(newEntry);
                    break;

                case "2":
                    myJournal.DisplayAllEntries();
                    break;

                case "3":
                    Console.WriteLine("Enter file name: ");
                    string _saveFile = Console.ReadLine();
                    myJournal.WriteToCSV(_saveFile);
                    Console.WriteLine("Journal saved!");
                    break;

                case "4":
                    Console.WriteLine("Enter file same: ");
                    string _loadFile = Console.ReadLine();
                    myJournal.ReadFromCSV(_loadFile);
                    Console.WriteLine($"Journal loaded! {_loadFile} has {myJournal._allEntries.Count} entries. ");
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye :)");
                    break;

                default:
                    Console.WriteLine("Invalid Option. select 1-5.");
                    break;

            }
        }

    }

    
    
}