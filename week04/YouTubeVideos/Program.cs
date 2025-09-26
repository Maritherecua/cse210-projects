//This program creates
//a few (3-4) YouTube video objects, puts each of this in a list,
// adds a list of 3-4 comments to them with the commenters' names, comment text, and number of likes.
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

class YouTubeVideo
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public List<Comment> _comments = new List<Comment>();

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (seconds): {_lengthInSeconds}");
        Console.WriteLine($"Number of comments: {_comments.Count}");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText} (Comments: {comment.NumberOfComments})");
        }
    }
}


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

        // Create a YouTube video and add a list ofcomments to it
        YouTubeVideo video1 = new YouTubeVideo();
        video1._title = "Learning C#";
        video1._author = "Tech Guru";
        video1._lengthInSeconds = 300;
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);

        YouTubeVideo video2 = new YouTubeVideo();
        video2._title = "Advanced C# Programming";
        video2._author = "Code Master";
        video2._lengthInSeconds = 450;
        video2._comments.Add(comment4);
        video2._comments.Add(comment2);
        video2._comments.Add(comment9);
        

        YouTubeVideo video3 = new YouTubeVideo();
        video3._title = "C# for Beginners";
        video3._author = "Beginner's Hub";
        video3._lengthInSeconds = 600;
        video3._comments.Add(comment5);
        video3._comments.Add(comment7);
        video3._comments.Add(comment10);

        // Create a list of videos
        List<YouTubeVideo> videos = new List<YouTubeVideo> { video1, video2, video3 };

        // Display details for each video
        foreach (var video in videos)
        {
            video.Display();
            Console.WriteLine(); // Add an empty line between videos
        }   
    }
}