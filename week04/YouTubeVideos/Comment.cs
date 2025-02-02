using System;
class Comment
{
    private string _commentAuthor;
    private string _text;

    public Comment(string commentAuthor, string text)
    {
        _commentAuthor = commentAuthor;
        _text = text;
    }

    public string GetCommentAuthor()
    {
        return _commentAuthor;
    }
    public string GetText()
    {
        return _text;
    }
}

