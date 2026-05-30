using System.Diagnostics.Contracts;

public class Comment
{
    // we will set our private attributtes so information is not overridden
    private string _commenterName;
    private string _commentText;

    // now build out the constructor 
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }
    
    // this will display the individual commment
    public void DisplayComment()
    {
        Console.WriteLine($"- {_commenterName}: \"{_commentText}\"");
    }
}