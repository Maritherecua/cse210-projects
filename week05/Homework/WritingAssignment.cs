public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor for WritingAssignment class passes only 2 parameters to base class constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return "Title: " + _title;
    }
}