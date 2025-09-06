using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string promptUserName = "What is your name? ";
        string name = GetUserInput(promptUserName);
        int promptUserNumber = int.Parse(GetUserInput("What is your favorite number? "));
        int squaredNumber = SquareNumber(promptUserNumber);
        DisplayResult(name, squaredNumber);
    }

    static void DisplayWelcomeMessage()

    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string GetUserInput(string prompt)

    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"Hello {name}, your favorite number squared is {squaredNumber}.");
    }
}