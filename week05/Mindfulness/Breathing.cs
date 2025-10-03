//This class begins with a starting message and prompt for the duration of the exercise.
//The description or type of exercise will be as "This exercise will help you relax by guiding your breathing in and out slowly.
//Clear your mind and focus your attention in your breathing"
//After the starting message it shows a series of alternating messages "Breath in...Breath out.."
//After each message, the program pause for several seconds showing a countdown. Continuing until reaching the seconds specified
//for duration by the user. It concludes with the finishing standard message for all exercises.
//It includes properties for the name, duration, and type of exercise, as well as a method to display the starting message.
//The Breathing class inherits from the Exercise class and adds a property for the number of breaths.
using System;

namespace Mindfulness
{
    public class Breathing : Exercise
    {
        public Breathing()
        {
            Name = "Breathing Exercise";
            Duration = 1; // default duration in minutes
            Type = "Breathing";
        }
        public void Run()
        {
            Console.WriteLine("This exercise will help you relax by guiding your breathing in and out slowly.");
            Console.WriteLine("Clear your mind and focus your attention on your breathing.");
            int totalSeconds = Duration * 60;
            int elapsed = 0;
            while (elapsed < totalSeconds)
            {
                Console.Write("Breathe in... ");
                for (int i = 5; i > 0; i--)
                {
                    Console.Write(i + " ");
                    System.Threading.Thread.Sleep(1000);
                }
                Console.WriteLine();

                elapsed += 5;
                if (elapsed >= totalSeconds) break;

                Console.Write("Breathe out... ");
                for (int i = 5; i > 0; i--)
                {
                    Console.Write(i + " ");
                    System.Threading.Thread.Sleep(1000);
                }
                Console.WriteLine();

                elapsed += 5;
            }
            Console.WriteLine("Great job! You have completed the Breathing Exercise for " + Duration + " minute(s).");
            DisplayFinishingMessage();
            ShowSpinner(3);
        }

        //public int BreathCount { get; set; }

        //public Breathing(string name, int duration, int breathCount)
        //: base(name, duration, "Breathing")
        //{
        //BreathCount = breathCount;
        //}

        //public void BreatheIn()
        //{
        //Console.WriteLine($"Inhaling... {BreathCount} times.");
        /// <summary>
        //}
        /// </summary>

        //public void BreatheOut()
        //{
        //Console.WriteLine($"Exhaling... {BreathCount} times.");
        //}
    }
}