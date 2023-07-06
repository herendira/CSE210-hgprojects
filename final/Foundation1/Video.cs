using System;
using System.Collections.Generic;
using System.IO;

public  class Video
{
    //Constructors
    public string _title;
    public string _author;
    public float _durationinsec;
   
    //constructors
    public Video(string title, string author, float durationinsec)
    {
        _title = title;
        _author = author;
        _durationinsec = durationinsec;
    }

   
    //getters, setters
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
    
    
}