using System;

namespace Mindfulness
{
    public class Reflecting : Exercise
    {
        public string ReflectionPrompt { get; set; }

        public Reflecting(string name, int duration, string reflectionPrompt)
            : base(name, duration, "Reflecting")
        {
            ReflectionPrompt = reflectionPrompt;
        }

        public void StartReflection()
        {
            Console.WriteLine($"Starting reflection: {ReflectionPrompt}");
        }

        public void StopReflection()
        {
            Console.WriteLine($"Stopping reflection on: {ReflectionPrompt}");
        }
    }
}