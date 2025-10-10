//This is the main entry point for the Eternal Quest application.
// It initializes the GoalManager and starts the application.
//Import necessary namespaces, has the Main method to run the program.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }

}