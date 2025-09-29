using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

        public Assignment(string studentName, string topic)
        {
            _studentName = studentName;
            _topic = topic;
        }
        // Getter methods for private fields (member variables)
        //These variables can be accessed ouside the class using these methods
        public string GetStudentName()
        {
            return _studentName;
        }

        public string GetTopic()
        {
            return _topic;
        }

        public string GetSummary()
        {
            return _studentName + " - " + _topic;
        }
    
}