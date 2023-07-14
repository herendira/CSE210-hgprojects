using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Lecture: Event
{
    //Variables
    private string _capacity;
    private string _speakername;
   
    
    
   
    //constructors
    public Lecture(string type, string title, string description, string date, string time, Address addressevent, string speakername, string capacity): base(type, title, description, date, time, addressevent) 
    {
        _capacity = capacity;
        _speakername = speakername;
    }
    
    //Getters
    public string GetCapacity()
    {
        return _capacity;
    }
    public string GetSpeakerName()
    {
        return _speakername;
    }

    //Oevrride Method
    public override string GetEvent()
    {
        return $"{base.GetEvent()}\nSpeaker: {_speakername}\nCapacity: {_capacity}";
    }
   
    





    



}
