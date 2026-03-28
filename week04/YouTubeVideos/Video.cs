using System;
using System.Collections.Generic;

public class Video
{
    public string _title = "";
    public string _author = "";
    public int _length = 0;

    public List<Comment> _comments = new List<Comment>();

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments: {GetNumberOfComments()}");

        foreach (Comment c in _comments)
        {
            c.DisplayComment();
        }

        Console.WriteLine();
    }
}
