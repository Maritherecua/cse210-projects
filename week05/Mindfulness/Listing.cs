//The exercise begins with a starting message and prompt for the duration used by all exercises.
//It includes a list of prompts related to "good things in life"
//After the starting message, it shows a random prompt from the list and allows the user to
//After displaying the prompt, gives a countdown of several seconds for the user to think about it. Then it prompts
//the user to list as many responses as they can related to the prompt.
//The user lists as many items as they can until the time specified for duration by the user is reached.
//Then displays back the number of items listed by the user.
//It concludes with the finishing standard message for all exercises.
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Mindfulness
{
    public class Listing
    {
        private int _count;
        private List<string> _prompts;
        public List<Exercise> Exercises { get; set; }
        public int Duration { get; set; }

        public Listing()
        {
            Exercises = new List<Exercise>();
            _prompts = new List<string>
            {
                "Who are your personal heroes?",
                "What are your personal achievements?",
                "Who are you grateful for in your life?",
                "What are your personal goals?",
                "Who inspires you to be better?",
                "When have you felt the most proud of yourself?",
                "What are some positive things about yourself?",
                "What are some things that make you happy?",
                "What are some things you are looking forward to?",
                "Who are some people who have made a positive impact on your life?",
                "When have you felt the most at peace?",
                "When have you felt the most loved?",
                "What is something new you learned recently?"
            };
        }
        public void GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            Console.WriteLine(_prompts[index]);
        }

        public void Run()
        {
            GetRandomPrompt();
            Random random = new Random();
            int promptIndex = random.Next(_prompts.Count);
            string selectedPrompt = _prompts[promptIndex];

            Console.WriteLine("This exercise will help you reflect on the good things in your life by listing as many things as you can in a certain area.");
            Console.Write("Enter the duration (in minutes) for this exercise: ");
            if (!int.TryParse(Console.ReadLine(), out int durationInput) || durationInput <= 0)
            {
                Console.WriteLine("Invalid input. Setting duration to 1 minute.");
                Duration = 1;
            }
            else
            {
                Duration = durationInput;
            }
            Console.WriteLine($"You will have {Duration} minutes to list as many responses as you can to the following prompt:");
            Console.WriteLine($"--- {selectedPrompt} ---");
            Console.WriteLine("Get ready...");
            ShowCountdown(5);

            DateTime endTime = DateTime.Now.AddMinutes(Duration);
            _count = 0;
            _count = 0;

            while (DateTime.Now < endTime)
            {
                Console.Write(">");
                string response = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(response))
                {
                    _count++;
                }
            
            }

            Console.WriteLine($"You listed {_count} items. Great job!");
            Console.WriteLine($"You have completed the Listing Exercise for {Duration} minute(s).");
            // If Listing inherits from Exercise, you can use DisplayFinishingMessage and ShowSpinner
            // Otherwise, use a pause here:
            System.Threading.Thread.Sleep(3000);
        }


        private void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"\rStarting in {i} second{(i > 1 ? "s" : "")}... ");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("\rLet's begin!               ");
        }
    }
}