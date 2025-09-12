// Program.cs is the main entry point for the Journal application.
// Features: new entry, shows a random prompt (from a list created) and saves the responses with the date and the prompt
// Displays the journal- iterates through all entries and displays them
// Saves the journal to a file and loads it from a file. Prompt the user for the filename to load or save from.
// this should replace any entries already in the journal
// Uses classes: Journal, Entry, PromptProvider
// Uses methods: AddEntry, DisplayEntries, SaveToFile, LoadFromFile, GetPrompts
// Shows a menu to the user to select from the features above
// Uses System, System.IO, System.Collections.Generic, System.Linq
using System;

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
            Console.WriteLine("Menu: Select an option (1-5): ");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Load journal from file");
            Console.WriteLine("4. Save journal to file");
            Console.WriteLine("5. Exit");
            Console.Write("Your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    var prompts = promptProvider.GetPrompts();
                    Random rand = new Random();
                    int index = rand.Next(prompts.Count);
                    string selectedPrompt = prompts[index];
                    Console.WriteLine($"Prompt: {selectedPrompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(selectedPrompt, response);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter filename to load from: ");
                    string loadFilename = Console.ReadLine();
                    if (System.IO.File.Exists(loadFilename))
                    {
                        var loadedEntries = new List<Entry>();
                        var lines = System.IO.File.ReadAllLines(loadFilename);
                        foreach (var line in lines)
                        {
                            var parts = line.Split('|');
                            if (parts.Length == 3)
                            {
                                DateTime date = DateTime.Parse(parts[0]);
                                string prompt = parts[1];
                                string resp = parts[2];
                                Entry entry = new Entry(prompt, resp) { Date = date };
                                loadedEntries.Add(entry);
                            }
                        }
                        journal.LoadEntries(loadedEntries);
                        Console.WriteLine("Journal loaded successfully.");
                    }
                    else
                    {
                        Console.WriteLine("File not found.");
                    }
                    break;
                case "4":
                    Console.Write("Enter filename to save to: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    Console.WriteLine("Journal saved successfully.");
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