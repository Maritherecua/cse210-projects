// This class represents a comment on a YouTube video.
// It includes properties for the commenter's name, 
//the comment text, and the number of likes.
// It also has a method to display the comment details.
public class Comment
{
    public string CommenterName { get; set; }
    public string CommentText { get; set; }
    public int NumberOfLikes { get; set; }

    public Comment(string commenterName, string commentText, int numberOfLikes)
    {
        CommenterName = commenterName;
        CommentText = commentText;
        NumberOfLikes = numberOfLikes;
    }

    public void DisplayCommentDetails()
    {
        Console.WriteLine($"Commenter: {CommenterName}");
        Console.WriteLine($"Comment: {CommentText}");
        Console.WriteLine($"Likes: {NumberOfLikes}");
        Console.WriteLine();
    }
}