using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Event
{
    //Constructors
    private string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    protected Address _addressevent;
    protected Outdoor _outdoor;
    
   
    
    
   
    //constructors
    public Event(string type, string title, string description, string date, string time, Address addressevent) 
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _addressevent = addressevent;
        
       

    }
    public Event()
    {
        _outdoor = null;
    }


    //Getters 

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    } 

    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }

    public Address GetAddressEvent()
    {
        return _addressevent;
    }

    public Outdoor GetWather()
    {
        return _outdoor;
    }
    
    //Methods
    public virtual string GetEvent()
    {
         return $"Type: {_type}";
    }
    public string GetShort()
    {
         return $"Type: {_type}\nTitle: {_title}\nDate: {_date}";
    }
    public string GetStandard()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_addressevent.GetAddress()}\n";
    }


    
    
    


  




}
