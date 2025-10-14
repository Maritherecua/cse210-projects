//Enhancement: added an extra class (achievement.cs) To create gamification with levels and achievements.
//Added progress tracking feature to monitor and display the user's progress towards their goals.
//This is the main entry point for the Eternal Quest application.
// It initializes the GoalManager and starts the application.
//Import necessary namespaces, has the Main method to run the program.
//Each goal type (SimpleGoal, EternalGoal) inherits from the base Goal class.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }

}