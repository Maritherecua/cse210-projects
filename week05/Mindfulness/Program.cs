//This program provides four exercises (Breathing, Reflecting, Listing, and Stretching), helping
//to work through them in stages using basic forms of delay(spinner or countdown).
//It has a common starting message providing the name of the exercise, a description (type) and asks for and sets the duration in seconds.
//Each activity ends with a common ending message, pause and tells the activity completed with the lenght in time, then pauses before finishing.
//Whenever it pauses shows an animation (spinner, or dots dispalyed on the screen).
//This is the main method that handles the menu and interaction.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflecting Exercise");
            Console.WriteLine("3. Listing Exercise");
            Console.WriteLine("4. Stretching Exercise");
            Console.WriteLine("5. Quit");
            Console.Write("Select an option (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    var breathing = new Mindfulness.Breathing();
                    breathing.Run();
                    break;
                case "2":
                    var reflecting = new Mindfulness.Reflecting();
                    reflecting.Run();
                    break;
                case "3":
                    var listing = new Mindfulness.Listing();
                    listing.Run();
                    break;
                case "4":
                    var stretching = new Mindfulness.Stretching();
                    stretching.Run();
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}