using System;
using System.Collections.Generic;

class Video
{
    private string _title;
    private string _videoAuthor;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string videoAuthor, int length)
    {
        _title = title;
        _videoAuthor = videoAuthor;
        _length = length;
        _comments = new List<Comment>();

    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_videoAuthor}");
        Console.WriteLine($"Number of comments: {_comments.Count}");
        Console.WriteLine($"Video length: {_length} seconds");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"Commented by {comment.GetCommentAuthor()}: {comment.GetText()}");
        }
    }
}

