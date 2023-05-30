using System;
using System.IO;
using System.Collections.Generic;

using System;

public class Assignment
{
    protected string _studentName;
    protected string _topic;

   
   
   public Assignment(string studentname, string topic)
   {
    _studentName = studentname;
    _topic= topic;
   }

   public string GetStuName()
   {
     return _studentName;
    
   }
   public string GetTopic()
   {
    return _topic;
    
   }
   public string GetSummary()
    {  
     
      return $" {_studentName} - {_topic}";
    }
}