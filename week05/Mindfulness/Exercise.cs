using System;

namespace Mindfulness
{
    public class Exercise
    {
        public string Name { get; set; }
        public int Duration { get; set; } // in minutes
        public string Type { get; set; } // e.g., "Yoga", "Meditation", "Walking"

        public Exercise(string name, int duration, string type)
        {
            Name = name;
            Duration = duration;
            Type = type;
        }

        public void Start()
        {
            Console.WriteLine($"Starting {Name} for {Duration} minutes.");
        }

        public void Stop()
        {
            Console.WriteLine($"Stopping {Name}.");
        }
    }
}