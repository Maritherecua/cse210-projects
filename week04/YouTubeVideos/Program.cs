//This program creates
//a few (3-4) YouTube video objects, puts each of this in a list,
// adds a list of 3-4 comments to them with the commenters' names, comment text, and number of comments.
// Iterates through the list of videos, displaying the details (title, author, length) of each video,
// the number of comments (from the method), and then list out all of the comments for that video.
//repeat for each video in the list.
// then list out all of the comments for that video. Repeat for each video in the list.
//using System.Text;
//using System.Threading.Tasks;
//Program.cs contains the Main method, which is the entry point of the application.
// It sets the values, and display them as specified, without user input.
using System.Collections.Generic;

using System;



class Program

{
    static void Main(string[] args)
    {
        // Create some comments
        Comment comment1 = new Comment("Alice", "Great video!", 10);
        Comment comment2 = new Comment("Bob", "Very informative.", 5);
        Comment comment3 = new Comment("Charlie", "I learned a lot.", 8);
        Comment comment4 = new Comment("David", "Thanks for the tips!", 12);
        Comment comment5 = new Comment("Eve", "Can't wait to try this out.", 7);
        Comment comment6 = new Comment("Frank", "This was super helpful.", 15);
        Comment comment7 = new Comment("Grace", "Well explained!", 9);
        Comment comment8 = new Comment("Hannah", "Awesome content!", 11);
        Comment comment9 = new Comment("Ian", "Keep up the good work!", 6);
        Comment comment10 = new Comment("Jack", "Loved the examples.", 14);

        // Create Video objects and add comments
        Video video1 = new Video("Learning C#", "Tech Guru", 300);
        video1.Comments.Add(comment1);
        video1.Comments.Add(comment6);
        video1.Comments.Add(comment3);

        Video video2 = new Video("Advanced C# Programming", "Code Master", 450);
        video2.Comments.Add(comment4);
        video2.Comments.Add(comment2);
        video2.Comments.Add(comment9);

        Video video3 = new Video("C# for Beginners", "Beginner's Hub", 600);
        video3.Comments.Add(comment5);
        video3.Comments.Add(comment7);
        video3.Comments.Add(comment10);

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display details for each video
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
            Console.WriteLine(); // Add an empty line between videos
        }
    }
}