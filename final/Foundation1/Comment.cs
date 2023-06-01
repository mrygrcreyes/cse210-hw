using System;

public class Comment
{
    private string _userName;
    private string _comment;

    public Comment(string userName,  string comment)
    {
        _userName = userName;
        _comment = comment;
    }
    public void GetCommentInfo()
    {
        Console.WriteLine($"UserName: {_userName} - {_comment}");
    }
}