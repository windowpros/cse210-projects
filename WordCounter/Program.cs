// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hallo Welt!");

        WordCounter wordCounter = new WordCounter("This is a Test Sentence Test Test");
        wordCounter.DisplayWords();

        int count = wordCounter.CountSingleWord("Test");
        Console.WriteLine(count);


    }
    
}