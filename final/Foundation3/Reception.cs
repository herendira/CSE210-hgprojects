using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Reception:Event
{

    private string _registration;
    
   
    //constructors
    public Reception(string type, string title, string description, string date, string time, Address addressevent, string registration):base(type, title, description, date, time, addressevent)
    {
        _registration = registration;
    }
    //Getters

    public string GetRegistration()
    {
        return _registration;
    }

    //Methods
    public override string GetEvent()
    {
        return $"{base.GetEvent()}\nReception: {_registration}";
    }
}