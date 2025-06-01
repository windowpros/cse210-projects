using System.IO.Compression;

class WordCounter
{
    private List<String> _words;

    public WordCounter(string text)
    {
        _words = new List<string>();
        SplitTextIntoWords(text);
    }

    private void SplitTextIntoWords(string text)
    {
        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            _words.Add(word);
        }
    }

    public void DisplayWords()
    {
        foreach (string word in _words)
        {
            Console.WriteLine(word);
        }
    }

    public int CountSingleWord(string searchword)
    {
        int count = 0;

        foreach (string word in _words)
        {
            if (word == searchword)
                count++;
        }

        return count;
    }
}