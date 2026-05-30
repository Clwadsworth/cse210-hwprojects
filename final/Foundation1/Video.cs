using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Video
{
    // private attributes to avoid overwriting
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    // building out the constructors for this class
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }
    // adding a Comment to the private collection
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length of Video: {_lengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        // put this line in to provide a visual separator
        Console.WriteLine(new string('-', 40));
    }

}