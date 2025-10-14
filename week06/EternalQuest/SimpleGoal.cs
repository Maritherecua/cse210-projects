// This class represents a simple goal with a description and a point value.
using System;

public class SimpleGoal : Goal
{

    private bool _completed;

    public SimpleGoal(string description, int points) : base(description, points)
    {
        _completed = false;
    }

    public override void DisplayGoal()
    {
        string status = _completed ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Description} (Points: {Points})");
    }

    public override int RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            return Points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _completed;
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
