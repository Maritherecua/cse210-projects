// This class represents a checklist goal with multiple tasks to complete.
using System;
using System.Collections.Generic;

public class ChecklistGoal : Goal
{
    private List<string> _tasks;
    private List<bool> _taskCompletionStatus;

    public ChecklistGoal(string description, int points, int target, int bonusPoints) : base(description, points)
    {
        _tasks = new List<string>();
        _taskCompletionStatus = new List<bool>();
    }

    public void AddTask(string task)
    {
        _tasks.Add(task);
        _taskCompletionStatus.Add(false);
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {Description} (Points: {Points})");
        for (int i = 0; i < _tasks.Count; i++)
        {
            string status = _taskCompletionStatus[i] ? "[X]" : "[ ]";
            Console.WriteLine($"  {status} {_tasks[i]}");
        }
    }

    public override int RecordEvent()
    {
        int totalPoints = 0;
        for (int i = 0; i < _tasks.Count; i++)
        {
            if (_taskCompletionStatus[i])
            {
                totalPoints += Points;
            }
        }
        return totalPoints;
    }

    public override bool IsComplete()
    {
        foreach (bool isComplete in _taskCompletionStatus)
        {
            if (!isComplete) return false;
        }
        return true;
    }

    public override string GetDetails()
    {
        return $"Description: {Description}, Points: {Points}, Tasks: {string.Join(", ", _tasks)}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Description}:{Points}:{string.Join(";", _tasks)}";
    }
}
