using System;
using System.Collections.Generic;

public class Video
{
    private List<Comment> _comments;
    private string _title;
    private int _length;
    private string _author;

    public Video(string title, string author, int length)
    {      
        _comments = new List<Comment>();
        _title = title;
        _author = author;
        _length = length;
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void VideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.User()}: {comment.CommentText()}");
        }

        Console.WriteLine();
    }

    public void AddComment(string user, string commentText)
    {
        Comment comment = new Comment(user, commentText);
        _comments.Add(comment);
    }
}
