// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Develop03 World!");

//         Scripture ScriptureMastery = new Scripture("And it came to pass");
//         ScriptureMastery.DisplayScripture();
//     }

// }

// ///
// /// 
// /// 

// class Scripture
// {
//     List<String> _wordlist;
//     string _word;

//     public void SplitTextIntoWords(string text)
//     {
//         string[] _arrayOfWords = text.Split(" ");
//         foreach (string word in _arrayOfWords)
//         {
//             _wordlist.Add(word);
//         }
//     }

//     public Scripture(string text)
//     {
//         _wordlist = new List<string>();
//         SplitTextIntoWords(text);
//     }

//     public void DisplayScripture()
//     {
//         foreach (string word in _wordlist)
//         {
//             Console.Write(word);
//         }
//     }
// }

// ///
// /// 
// /// 

// class Word
// {
//     string _word;
//     bool _hidden;

//     public void DisplayWord()
//     {
//         foreach (string word in _wordslist)
//         {
//             if (_hidden == false)
//             {
//                 Console.WriteLine(_word);
//             }
//             else
//             {
//                 Console.WriteLine("___");
//             }
//         }
//     }

// }