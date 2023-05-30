using System;
using System.IO;
using System.Collections.Generic;

public class WritingAssig : Assignment
{
    protected string _title;
    
    
   
    public WritingAssig(string _studentName, string _topic, string title):base(_studentName, _topic)
    {
     _title= title;
    
    }
    public string GetTitle()
   {
     return _title;
    
   }
   
   
    public string GetWritAssig()
    {
     return $"{_title} - {_studentName}";
    
    }
   
   
}