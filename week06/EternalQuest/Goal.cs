//This base class defines the common responsibilities, behaviors, and attributes of all goals.
using System;

public abstract class Goal
{
    public string Description { get; set; }
    public int Points { get; set; }

    public Goal(string description, int points)
    {
        Description = description;
        Points = points;
    }

    public abstract void DisplayGoal();
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetails();
    public abstract string GetStringRepresentation();
    
}
