using System;

namespace Mindfulness
{
    public class Breathing : Exercise
    {
        public int BreathCount { get; set; }

        public Breathing(string name, int duration, int breathCount)
            : base(name, duration, "Breathing")
        {
            BreathCount = breathCount;
        }

        public void BreatheIn()
        {
            Console.WriteLine($"Inhaling... {BreathCount} times.");
        }

        public void BreatheOut()
        {
            Console.WriteLine($"Exhaling... {BreathCount} times.");
        }
    }
}