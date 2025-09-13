
using System;
using System.Collections.Generic;
using System.IO;

// Define the Entry class
// (Removed duplicate Entry class definition to resolve conflict)

public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response)
    {
        Entry newEntry = new Entry(prompt, response);
        entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
            Console.WriteLine();
        }
    }

    public List<Entry> GetEntries()
    {
        return entries;
    }

    public void LoadEntries(List<Entry> loadedEntries)
    {
        entries = loadedEntries;
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date.ToString("o")}|{entry.Prompt}|{entry.Response}");
            }
        }
    }
}

