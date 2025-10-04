using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Mindfulness
{
    public class Stretching
    {
        private List<string> _stretches;

        private void ShowDotCountdown(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(". ");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        public Stretching()
        {
            _stretches = new List<string>
            {
                "Neck Stretch",
                "Shoulder Stretch",
                "Triceps Stretch",
                "Wrist Stretch",
                "Back Stretch",
                "Arms Stretch",
                "Legs Stretch",
                "Calf Stretch",
                "Fingers Stretch",
                "Chest Stretch",
                "Neck Stretch",
                "Hands Stretch",
                "Foot Stretch"
            };
        }

        public void Run()
        {
            Console.WriteLine("This exercise will guide you through a series of stretches to help release tension and promote relaxation.");
            Console.Write("Enter the duration (in minutes) for this exercise: ");
            if (!int.TryParse(Console.ReadLine(), out int durationInput) || durationInput <= 0)
            {
                Console.WriteLine("Invalid input. Setting duration to 1 minute.");
                durationInput = 1;
            }

            Console.WriteLine($"You will have {durationInput} minutes to complete the following stretches:");
            ShowCountdown(5);

            DateTime endTime = DateTime.Now.AddMinutes(durationInput);
            int stretchCount = 0;

            while (DateTime.Now < endTime)
            {
                string stretch = GetRandomStretch();
                Console.WriteLine($"\nNext stretch: {stretch}");
                Console.WriteLine("Hold this stretch for 15 seconds...");
                ShowDotCountdown(15);
                stretchCount++;
            }

            Console.WriteLine($"\nYou completed {stretchCount} stretches. Great job!");
        }

        private string GetRandomStretch()
        {
            Random random = new Random();
            int index = random.Next(_stretches.Count);
            return _stretches[index];
        }

        private void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"\rStarting in {i} second{(i > 1 ? "s" : "")}... ");
                System.Threading.Thread.Sleep(2000);
            }
            Console.WriteLine("\rLet's begin!               ");
        }
    }
}