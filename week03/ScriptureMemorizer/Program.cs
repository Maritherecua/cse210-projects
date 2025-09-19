//Enhancements made to Reference.cs and Program.cs to improve scripture 
//loading and handling.
//It loads scripture text from an external file, allowing for easy
//updates and additions to the scripture database without modifying the code.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
// This program stores and displays a scripture both by reference and text.
class Program
{
    static void Main(string[] args)
    {
        // Load scriptures from an external file
        // Use absolute path to Scripture.txt based on workspace structure
        string filePath = "/Users/mariatarroyo/Desktop/cse210-projects/week03/ScriptureMemorizer/Scripture.txt";
        var scriptures = LoadScriptures(filePath);
        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found.");
            return;
        }

        // Randomly select a scripture
        var random = new Random();
        var scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }

            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");
            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWord();
        }
    }

    static List<Scripture> LoadScriptures(string filePath)
    {
        var scriptures = new List<Scripture>();
        if (!File.Exists(filePath))
            return scriptures;

        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            var parts = line.Split('|');
            if (parts.Length == 2)
            {
                try
                {
                    scriptures.Add(new Scripture(parts[0].Trim(), parts[1].Trim()));
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Warning: Invalid reference format skipped: {parts[0].Trim()}");
                }

            }
        }
        return scriptures;
    }
}
