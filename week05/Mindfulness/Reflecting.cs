//This exercise begins with the standard starting message and prompt for the duration used by all activities. 
//After the starting message it shows a random prompt 
//After displaying the prompt, the program asks the user to reflect on questions related to this experience.
//This questions are pulled randomly from a list.
// after each question, the program pauses for several seconds showing a countdown or a spinner.
//This continues until reaching the seconds specified for duration by the user.
using System;

namespace Mindfulness
{
    public class Reflecting : Exercise
    {
        private List<string> _prompts = new List<string>
                {
                    "Think of a time you did something really difficult.",
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless.",
                    "Think of a time you emphatized with somebody's feelings.",
                    "Think of a time when you didn't care about consequences while doing the right thing.",
                    "Think of your most joyful moment this week",
                    "Think of your favorite way to spend a day",
                    "Think of a time when you felt truly at peace",
                    "Think of a time when you overcame a challenge",
                    "Think of a time when you felt proud of yourself"
                };
        private List<string> _questions = new List<string>
        {
            "What did you learn about yourself through this experience?",
            "How can you apply this experience to future challenges?",
            "Why was this experience meaningful to you?",
            "What strengths did you use to overcome this challenge?",
            "What could you learn from this experience that applies to other situations?",
            "How did it impact you and those around you?",
            "What would you do differently if faced with a similar situation?",
            "What other situations does this remind you of?",
            "What emotions did you experience during this time?",
            "What new perspectives did you gain from this experience?"

        };
        public Reflecting()
        {
            // Default constructor
        }

        public void Run()
        {
            Console.WriteLine("This exercise will help you reflect on times in your life when you've shown strength and resilience, to recognize your inner power and how you can use it in other aspects of your life.");
            Console.Write("Enter the duration of the exercise in seconds: ");
            if (!int.TryParse(Console.ReadLine(), out int duration))
            {
                Console.WriteLine("Invalid input. Using default duration of 30 seconds.");
                duration = 30;
            }
            Console.WriteLine("\nGet ready...");
            ShowSpinner(5);

            // Show a random prompt
            string prompt = GetRandomPrompt();
            Console.WriteLine($"\nPrompt: {prompt}");
            ShowSpinner(5);

            int elapsed = 0;
            Random rand = new Random();
            while (elapsed < duration)
            {
                string question = GetRandomQuestion();
                Console.WriteLine($"\nReflect: {question}");
                ShowSpinner(5);
                elapsed += 5;
            }

            Console.WriteLine("\nWell done! You have completed the Reflecting Exercise.");
            ShowSpinner(5);
        }
        private string GetRandomPrompt()
        {
            Random rand = new Random();
            int index = rand.Next(_prompts.Count);
            return _prompts[index];
        }
        // Removed duplicate declaration of DisplayPrompt
        private string GetRandomQuestion()
        {
            Random rand = new Random();
            int index = rand.Next(_questions.Count);
            return _questions[index];
        }
        private void DisplayPrompt()
        {
            // Method implementation goes here
            string prompt = GetRandomPrompt();
            Console.WriteLine(prompt);
        }
        private void DisplayQuestion()
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
        }
        //public Reflecting(string name, int duration, string reflectionPrompt)
        //: base(name, duration, "Reflecting")
        //{
        //ReflectionPrompt = reflectionPrompt;
        //}

        //public void StartReflection()
        //{
        //Console.WriteLine($"Starting reflection: {ReflectionPrompt}");
        /// <summary>
        /// /}
        /// </summary>

        //public void StopReflection()
        //{
        //Console.WriteLine($"Stopping reflection on: {ReflectionPrompt}");
        //}
    }
}