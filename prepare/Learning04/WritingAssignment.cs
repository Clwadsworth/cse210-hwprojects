public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        // private information we are holding only in this class
        _title = title;
    }

    public string GetWritingInformation()
    {
        // returns the assignment list for the topic
        return $"{_title} by {GetStudentName()}";
    }
}