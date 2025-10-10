// This class represents a simple goal with a description and a point value.
using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string description, int points) : base(description, points)
    {
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {Description} (Points: {Points})");
    }

    public override int RecordEvent()
    {
        return Points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetails()
    {
        return $"Description: {Description}, Points: {Points}";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{Description}:{Points}";
    }
}
