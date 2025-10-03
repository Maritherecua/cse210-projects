//This is the base class for different types of mindfulness exercises.
//It includes properties for the name, duration, and type of exercise, as well as methods to start and stop the exercise.
//The Exercise class serves as a parent class for specific exercise types like: Breathing, Reflecting, and Listing,
//which inherit from it and add their own unique properties and methods.

using System;

namespace Mindfulness
{
    public class Exercise
    {
        public string Name { get; set; }
        public int Duration { get; set; } // in seconds
        public string Type { get; set; } // e.g., "Breathing", "Reflecting", "Listing"

        public Exercise()
        {
            // Default constructor
        }
            public void DisplayStartingMessage()
            {
                Console.WriteLine($"Welcome to the {Name} exercise!");
                Console.WriteLine($"This exercise will help you with {Type.ToLower()} for {Duration} minutes.");
                Console.WriteLine("Get ready...");
            }

            public void DisplayFinishingMessage()
            {
                Console.WriteLine($"Great job! You've completed the {Name} exercise for {Duration} minutes.");
                Console.WriteLine("Take a moment to reflect on how you feel now.");
            }

            public void ShowSpinner(int seconds)
            {
                for (int i = 0; i < seconds; i++)
                {
                    Console.Write("|");
                    System.Threading.Thread.Sleep(500);
                    Console.Write("\b \b");
                    Console.Write("/");
                    System.Threading.Thread.Sleep(500);
                    Console.Write("\b \b");
                    Console.Write("-");
                    System.Threading.Thread.Sleep(500);
                    Console.Write("\b \b");
                    Console.Write("\\");
                    System.Threading.Thread.Sleep(500);
                    Console.Write("\b \b");
                }
            }
            public void ShowCountdown(int seconds)
            {
                for (int i = seconds; i > 0; i--)
                {
                    Console.Write(i);
                    System.Threading.Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine();
            }
        //public void Start()
        //{
            //Console.WriteLine($"Starting {Name} for {Duration} minutes.");
        //}

        //public void Stop()
        //{
            //Console.WriteLine($"Stopping {Name}.");
        //}
    }
}