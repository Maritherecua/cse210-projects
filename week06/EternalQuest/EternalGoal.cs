// This class represents a goal that can be completed multiple times for points.
using System;

public class EternalGoal : Goal
{
    private int _completionCount;

    public EternalGoal(string description, int points) : base(description, points)
    {
        _completionCount = 0;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {Description} (Points: {Points}, Completed: {_completionCount})");
    }

    public override int RecordEvent()
    {
        _completionCount++;
        return Points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetails()
    {
        return $"Description: {Description}, Points: {Points}, Completed: {_completionCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{Description}:{Points}:{_completionCount}";
    }
}
