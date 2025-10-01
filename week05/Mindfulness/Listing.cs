using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class Listing
    {
        public List<Exercise> Exercises { get; set; }

        public Listing()
        {
            Exercises = new List<Exercise>();
        }

        public void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }

        public void ShowExercises()
        {
            foreach (var exercise in Exercises)
            {
                Console.WriteLine($"- {exercise.Name} ({exercise.Type}): {exercise.Duration} minutes");
            }
        }
    }
}