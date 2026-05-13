public class MathAssignment : Assignment
{
    private string _section;
    private string _problems;

    public MathAssignment(string studentName, string topic, string section, string problems) : base(studentName, topic)
    {
        // private information we are holding only in this class
        _section = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";
        // returns the assignment list for the topic
    }

}
