// This class represents a comment on a YouTube video.
// It includes properties for the commenter's name, 
//the comment text, and the number of comments.
// It also has a method to display the comment details.
public class Comment
{
    public string CommenterName { get; set; }
    public string CommentText { get; set; }
    public int NumberOfComments { get; set; }

    public Comment(string commenterName, string commentText, int numberOfComments)
    {
        CommenterName = commenterName;
        CommentText = commentText;
        NumberOfComments = numberOfComments;
    }

    public void DisplayCommentDetails()
    {
        Console.WriteLine($"Commenter: {CommenterName}");
        Console.WriteLine($"Comment: {CommentText}");
        Console.WriteLine($"Comments: {NumberOfComments}");
        Console.WriteLine();
    }
}