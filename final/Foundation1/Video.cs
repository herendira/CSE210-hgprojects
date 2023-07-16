using System;
using System.Collections.Generic;
using System.IO;

public  class Video
{
    //Constructors
    public string _title;
    public string _author;
    public float _durationinsec;
    public List<Comment> _comments;
   
    //constructors
    public Video(string title, string author, float durationinsec)
    {
        _title = title;
        _author = author;
        _durationinsec = durationinsec;
        _comments = new List<Comment>();
    }

   
    //Getters
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public float GetDurationinSec()
    {
        return _durationinsec;
    }
    public int GetComNumber()
    {
        return _comments.Count;
    }
    public void AddingComments(Comment comment)
    {
         _comments.Add(comment);
    }
    public void DisplayComments()
    {
       foreach(Comment comment in _comments)
       {
            Console.WriteLine($"{comment._commenter}, {comment._comment}");
       }
    }  
    
}