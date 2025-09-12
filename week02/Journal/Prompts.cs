// prompts.cs contains a list of prompts for journal entries
//to select from
using System;
using System.Collections.Generic;
public class PromptProvider
{
public List<string> GetPrompts()
{
    var prompts = new List<string>
    {
        "What did you learn today?",
        "What was the highlight of your day?",
        "What challenges did you face?",
        "What are you grateful for?",
        "How did you help someone today?",
        "How did you take care of yourself today?",
        "What made you smile today?",
        "What do you want to achieve tomorrow?",
        "What is your favorite book and why?",
        "What did you do for fun today?",
        "What is a goal you have for this year?",
        "Describe a memorable trip you took.",
        "What is a skill you want to learn and why?",
        "Who has influenced you the most in your life?",
        "If you could do something over again today, what would it be?"
    };
    return prompts;
}

// Example usage to avoid 'declared but never used' error
public static void PrintPrompts()
{
    var prompts = new PromptProvider().GetPrompts();
    foreach (var prompt in prompts)
    {
        Console.WriteLine(prompt);
    }
}

}
