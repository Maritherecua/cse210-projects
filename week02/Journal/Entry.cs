// Entry.cs shows a pompt(from a list created)
//and saves the response with the date and the prompt
using System;
public class Entry
{
    public string _prompt { get; set; }
    public string _response { get; set; }
    public DateTime _date { get; set; }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date.ToShortDateString()}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
    }

    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now;
    }
}