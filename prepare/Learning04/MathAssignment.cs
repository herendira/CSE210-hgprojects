using System;
using System.IO;
using System.Collections.Generic;



public class MathAssig : Assignment
{
    private string _textbookSection;
    private string _problems;

    
   public MathAssig(string _studentName, string _topic, string textbookSection, string problems): base(_studentName, _topic)
   {
    _textbookSection = textbookSection;
    _problems= problems;
   }
   public string GetHomeworkList()
    {  
     
      return $"{_textbookSection} - {_problems}";
    }
}