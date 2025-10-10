// GoalManager.cs

using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        // Main game loop
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score}");
    }
    public  void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.Description);
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            goal.DisplayGoal();
        }
    }

    public void CreateGoal()
    {
        // Logic to create a new goal
    }

    public void RecordEvent()
    {
        // Logic to record an event for a goal
    }

    public void SaveGoals()
    {
        // Logic to save goals to a file
    }

    public void LoadGoals()
    {
        // Logic to load goals from a file
    }

}