using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Client
{
    //Variables
    private string _customername;
    private string _wholeaddress;
    private Address _address {get; set;}  
    
   
    //constructors
    public Client(string customername, string wholeaddress)
    {
        _customername = customername;
        _wholeaddress = wholeaddress;
    }
    public Client()
    {
        
    }
     public Client(Address address)
    {
        _address = address;
    }

    //Getters and Setters
    public string GetCustName()
    {
        return _customername;
    }
    public void SetCusName(string customername)
    {
        _customername = customername;
    }
    public string GetWholeAddress()
    {
        return _wholeaddress;
    }
    
    public Address GetAdd()
    {
       return _address;
    }
  
   
}      