using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's the magic number?");
        int magicNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("What is your guess?");
        int guess = int.Parse(Console.ReadLine());
        while (guess != magicNumber)
        {
            if (guess > magicNumber)
            {
                Console.WriteLine("  Lower.");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("  Higher.");
            }
            else
            {
                Console.WriteLine("  Correct guess!");
            }
        }

        Random random = new();
        int newMagicNumber = random.Next(1, 101);
        
        int newGuess = -1;
        while (newGuess != newMagicNumber)
        {
            Console.Write("What is your guess? ");
            newGuess = int.Parse(Console.ReadLine());

            if (newGuess > newMagicNumber)
            {
                Console.WriteLine("  Lower.");
            }
            else if (newGuess < newMagicNumber)
            {
                Console.WriteLine("  Higher.");
            }
            else
            {
                Console.WriteLine("  Correct!");
            }
        }
    }
}