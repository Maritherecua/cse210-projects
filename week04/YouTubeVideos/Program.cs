//This program creates
//a few (3-4) YouTube video objects, puts each of this in a list,
// adds a list of 3-4 comments to them with the commenters' names, comment text, and number of likes.
// Iterates through the list of videos, displaying the details (title, author, length) of each video,
// the number of comments (from the method), and then list out all of the comments for that video.
//repeat for each video in the list.
//using System.Linq;
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
        Comment comment1 = new Comment();
        comment1._commenterName = "Alice";
        comment1._commentText = "Great video!";
        comment1._likes = 10;

        Comment comment2 = new Comment();
        comment2._commenterName = "Bob";
        comment2._commentText = "Very informative.";
        comment2._likes = 5;

        Comment comment3 = new Comment();
        comment3._commenterName = "Charlie";
        comment3._commentText = "I learned a lot.";
        comment3._likes = 8;

        // Create a YouTube video and add comments to it
        YouTubeVideo video1 = new YouTubeVideo();
        video1._title = "Learning C#";
        video1._author = "Tech Guru";
        video1._lengthInSeconds = 300;
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);

        YouTubeVideo video2 = new YouTubeVideo();
        video2._title = "Advanced C# Programming";
        video2._author = "Code Master";
        video2._lengthInSeconds = 450;
        video2._comments.Add(comment3);

        // Create a list of videos
        List<YouTubeVideo> videos = new List<YouTubeVideo> { video1, video2 };

        // Display details for each video
        foreach (var video in videos)
        {
            video.Display();
            Console.WriteLine(); // Add an empty line between videos
        }   
    }
}