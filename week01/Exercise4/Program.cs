using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();


        // numbers.Add(i);
        //Random random = new();
        //int index = random.Next(numbers.Count)
        // //int magicNumber = numbers[index];

        int enteredNumber = -1;
        while (enteredNumber != 0)
        {
            Console.Write("Please enter a number (0 to quit): ");
            string enteredResponse = Console.ReadLine();
            enteredNumber = int.Parse(enteredResponse);

            if (enteredNumber != 0)
            {
                numbers.Add(enteredNumber);
            }
            Console.WriteLine("Numbers entered so far: " + string.Join(", ", numbers));
        }
        //Compute the sum and average of the numbers
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("Sum: " + sum);
        float average = (numbers.Count > 0) ? (float)sum / numbers.Count : 0;

        Console.WriteLine("Average: " + average);
        //Find the maximum number
        int max = (numbers.Count > 0) ? numbers[0] : 0;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }

        }

        
    }
    
    
    
}