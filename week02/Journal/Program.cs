// Program.cs is the main entry point for the Journal application.
// Features: new entry, shows a random prompt (from a list created) and saves the responses with the date and the prompt
// Displays the journal- iterates through all entries and displays them
// Enhancesment-Saves the journal to a file and names it to load or save from without asking for user input.
// this should replace any entries already in the journal
// Uses classes: Journal, Entry, PromptProvider
// Uses methods: AddEntry, DisplayEntries, SaveToFile, LoadFromFile, GetPrompts
// Shows a menu to the user to select from the features above
// Uses System, System.IO, System.Collections.Generic, System.Linq
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();
        PromptProvider promptProvider = new PromptProvider();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display Journal entries");
            Console.WriteLine("3. Load journal from file");
            Console.WriteLine("4. Save journal to file");
            Console.WriteLine("5. Exit");
            Console.Write("Your choice (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    var _prompts = promptProvider.GetPrompts();
                    Random rand = new Random();
                    int index = rand.Next(_prompts.Count);
                    string selectedPrompt = _prompts[index];
                    Console.WriteLine($"Prompt: {selectedPrompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(selectedPrompt, response);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    string loadFilename = "Journal.txt";
                    if (System.IO.File.Exists(loadFilename))
                    {
                        var _loadedEntries = new List<Entry>();
                        var _lines = System.IO.File.ReadAllLines(loadFilename);
                        foreach (var line in _lines)
                        {
                            var _parts = line.Split('|');
                            if (_parts.Length == 3)
                            {
                                DateTime date;
                                // Try to parse using the ISO 8601 format (used when saving)
                                if (!DateTime.TryParseExact(_parts[0], "o", null, System.Globalization.DateTimeStyles.None, out date))
                                {
                                    // Fallback to default parse if needed
                                    if (!DateTime.TryParse(_parts[0], out date))
                                    {
                                        date = DateTime.Now; // fallback to now if parsing fails
                                    }
                                }
                                string prompt = _parts[1];
                                string resp = _parts[2];
                                Entry entry = new Entry(prompt, resp) { Date = date };
                                _loadedEntries.Add(entry);
                            }
                        }
                        string journalContent = string.Join(Environment.NewLine, _loadedEntries.Select(e => $"{e.Date}|{e.Prompt}|{e.Response}"));
                        journal.LoadEntries(_loadedEntries);
                        Console.WriteLine("Journal loaded successfully.");
                        Console.WriteLine(journalContent);
                    }
                    else
                    {
                        Console.WriteLine("File 'Journal.txt' not found.");
                    }
                    break;
                case "4":
                    journal.SaveToFile("Journal.txt");
                    Console.WriteLine("Journal saved to 'Journal.txt' successfully.");
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}