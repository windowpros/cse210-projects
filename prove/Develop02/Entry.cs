using System.ComponentModel.DataAnnotations;
using System.Data;

class Entry
{
    private string _date;
    private string _daysActivities;
    private string _prompt;
    private int _rank;

    // File loading features below.
    public Entry() { }

    public Entry(string date, string prompt, string response, int rank)
    {
        _date = date;
        _prompt = prompt;
        _daysActivities = response;
        _rank = rank;
    }

    public void CreateNewEntry()
    {
        _date = DateTime.Now.ToString("d");

        _prompt = GeneratePrompt();
        Console.WriteLine($"Prompt: {_prompt}");
        _daysActivities = Console.ReadLine();

        Console.WriteLine("Rank today on a scale 1 to 5: ");
        string _rankString = Console.ReadLine();
        while (!int.TryParse(_rankString, out _rank))
        {
            Console.WriteLine("Invalid input. Please enter a whole number:");
            _rankString = Console.ReadLine();
        }
    }

    public string GeneratePrompt()
    {
        List<string> _prompts = new List<string>
        {
            "What are you grateful for today?",
            "Who did you serve today?",
            "What was a tender mercy you witnessed today?",
            "How will you be better tomorrow?",
            "Who do you think could use your talents?",
            "What did you learn today?"

        };

        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_daysActivities}");
        Console.WriteLine($"Rank: {_rank}/5");
        Console.WriteLine();
    }
    
    public string GetDate() => _date;
    public string GetPrompt() => _prompt;
    public string GetResponse() => _daysActivities;
    public int GetRank() => _rank;


    

    // public void DisplayEntry()
    // {}

    // public void EntryToString()
    // {}

    // public void CreateEntryWithPrompt()
    // {}

    // public void CreateEntryWithData()
    // {}
}