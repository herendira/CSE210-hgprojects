using System;
using System.Collections.Generic;
using System.IO;

public class Comment                 
{
    //Variables
    public string _commenter;
    public string _comment;
    public List<Comment> _comments;

    //Constructors
    public Comment(string commenter, string comment)
    {
       _commenter = commenter;
       _comment = comment;
    }
    public Comment()
    {
        _comments = new List<Comment>();
    }

    //Getters

    public string GetCommenter()
    {
        return _commenter;
    }

     public string GetComment()
    {
        return _comment;
    }

    //Methods
    public void AddingComments(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CommentsNum()
    {
        return _comments.Count;
    }

    public void DisplayComments()
    {
        foreach(Comment comment in _comments)
        {
            Console.WriteLine($"{comment._commenter}, {comment._comment}");
        }
        
    }
}    