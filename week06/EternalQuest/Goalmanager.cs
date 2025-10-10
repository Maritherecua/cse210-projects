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
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. View Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                        RecordEvent();
                        break;
                case "4":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score}");
    }
    public void ListGoalNames()
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
        Console.WriteLine("\nSelect the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for this goal: ");
        int points = 0;
        if (!int.TryParse(Console.ReadLine(), out points))
        {
            Console.WriteLine("Invalid input. Setting points to 10.");
            points = 10;
        }

        Goal newGoal = null;
        switch (typeChoice)
        {
            case "1":
                newGoal = new SimpleGoal(description, points);
                break;
            case "2":
                newGoal = new EternalGoal(description, points);
                break;
            case "3":
                newGoal = new ChecklistGoal(description, points, 5, 0); // Example with target count 5
                break;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        // Logic to record an event for a goal
        Console.Write("Enter the number of the goal to record an event for: ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
        {
            Goal selectedGoal = _goals[goalIndex - 1];
            int pointsEarned = selectedGoal.RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"Event recorded for goal: {selectedGoal.Description}. Points earned: {pointsEarned}. Total score: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid goal number. Please try again.");
        }
    }

    public void SaveGoals()

    {
        // Logic to save goals to a file
        foreach (var goal in _goals)
        {
            string saveData = goal.GetSaveData();
            // Write saveData to a file
        }
    }

    public void LoadGoals()
    {
        // Logic to load goals from a file
        // For each line in the file, parse the goal type and create the appropriate Goal object
        // Then add it to the _goals list
        string[] lines = System.IO.File.ReadAllLines("goals.txt");
        foreach (var line in lines)
        {
            var parts = line.Split(':');
            if (parts.Length > 0)
            {
                string goalType = parts[0];
                Goal goal = null;
                switch (goalType)
                {
                    case "SimpleGoal":
                        if (parts.Length == 3 && int.TryParse(parts[2], out int simplePoints))
                        {
                            goal = new SimpleGoal(parts[1], simplePoints);
                        }
                        break;
                    case "EternalGoal":
                        if (parts.Length == 3 && int.TryParse(parts[2], out int eternalPoints))
                        {
                            goal = new EternalGoal(parts[1], eternalPoints);
                        }
                        break;
                    case "ChecklistGoal":
                        if (parts.Length == 5 && int.TryParse(parts[2], out int checklistPoints) &&
                            int.TryParse(parts[3], out int targetCount) &&
                            int.TryParse(parts[4], out int currentCount))
                        {
                            goal = new ChecklistGoal(parts[1], checklistPoints, targetCount, currentCount);
                        }
                        break;
                }
                if (goal != null)
                {
                    _goals.Add(goal);
                }
            }
        }
    }

}