class Journal
{
    public List<Entry> _allEntries = new List<Entry>();

    public void DisplayAllEntries()
    {
        foreach (Entry e in _allEntries)
        {
            e.DisplayEntry();
        }
    }

    public void WriteToCSV(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine("Date|Prompt|Response|Rank"); // Header row

            foreach (Entry entry in _allEntries)
            {
                string date = entry.GetDate();
                string prompt = EscapeCSV(entry.GetPrompt());
                string response = EscapeCSV(entry.GetResponse());
                string rank = entry.GetRank().ToString();

                writer.WriteLine($"{date}|{prompt}|{response}|{rank}");
            }
        }
    }

    public void ReadFromCSV(string filename)
    {
        _allEntries.Clear();

        string[] lines = File.ReadAllLines(filename);

        // Skip the header
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            if (parts.Length == 4)
            {
                string date = parts[0];
                string prompt = UnescapeCSV(parts[1]);
                string response = UnescapeCSV(parts[2]);
                int rank = int.Parse(parts[3]);

                Entry entry = new Entry(date, prompt, response, rank);
                _allEntries.Add(entry);
            }
        }
    }

    private string EscapeCSV(string input)
    {
        if (input.Contains("|") || input.Contains("\"") || input.Contains("\n"))
        {
            input = input.Replace("\"", "\"\"");
            return $"\"{input}\"";
        }
        return input;
    }

    private string UnescapeCSV(string input)
    {
        if (input.StartsWith("\"") && input.EndsWith("\""))
        {
            input = input.Substring(1, input.Length - 2);
            input = input.Replace("\"\"", "\"");
        }
        return input;
    }

}