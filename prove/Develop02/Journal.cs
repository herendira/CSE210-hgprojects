using System;
using System.IO;
using System.Collections.Generic;




using System;
using System.Collections.Generic;

public class Journal
{
    public List<Journal>journallist = new List<Journal>();
    public string _EntryText;

    public string _Prompt;
    public string _Date;
    public string _Writemyday;
    public string prompts()
    {
        var random = new Random();
        var list = new List<string>{"What was the best part of your day","How do you felt the Spirit this day?","Did you helped someone?","What did you learn?","Which were your feeling during the day?" };
        
        int index = random.Next(list.Count);
        return list[index];
    }
    
    public string timeEntry()
    {   
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        return dateText;
    }

    public void Write()

    {
        Console.WriteLine("It's time to write:  ");
        Journal journal = new Journal();
        journal._Writemyday = $"Date {_Date}, {_EntryText}";

        journallist.Add(journal);
    }

    public void Display()
    {
        
        foreach(Journal i in journallist)
        {
            Console.WriteLine(i._Writemyday);
        }
        
    }
        public string ToCsvString()
    {
        return $"{_Date},{_Prompt},{_EntryText}";
    }

    
}