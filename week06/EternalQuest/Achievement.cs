// Achievement.cs
using System;

public class Achievement
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsUnlocked { get; set; }

    public Achievement(string name, string description)
    {
        Name = name;
        Description = description;
        IsUnlocked = false;
    }

    public void Unlock()
    {
        IsUnlocked = true;
        Console.WriteLine($"Achievement unlocked: {Name} - {Description}");
    }
}
