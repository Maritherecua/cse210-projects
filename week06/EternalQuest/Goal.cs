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
    //this method should do what is necessary for each goal
    //such as adding to the count of completions for a ChecklistGoal
    //and return the number of points earned for that event.
    public abstract bool IsComplete();
    //This method should return true if the goal is complete, false otherwise.
    //For EternalGoal, it should always return false.
    //For ChecklistGoal, it should return true when the goal has been completed the required number
    public abstract string GetDetails();
    //This method should include the checkbox, the short name, and the description
    //for the goal, formatted for display to the user.
    //This method should handle the logic for recording an event related to the goal
    //and return the number of points earned for that event.
    //should be overridden in the ChecklistGoal class to indicate number of times the goal is completed so far
    
    public abstract string GetStringRepresentation();
    //this method should be overridden in derived classes to provide specific string representations
    //Should provide all necessary information to recreate the goal object
    //in a way that can be easily saved to a file  and loaded later.
    public virtual string GetSaveData()
    {
        return $"{GetGoalType()}:{Description}:{Points}";
    }
    public virtual string GetGoalType()
    {
        return "Goal";
    }
}
