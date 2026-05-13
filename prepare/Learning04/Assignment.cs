public class Assignment
{
    // private information we are holding only in this class
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        // This will be used for all the other classes
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // For the WritingAssignment class
    public string GetStudentName()
    {
        return _studentName;
    }
}
