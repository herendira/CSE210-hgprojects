using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Address
{
    //Constructors
    private string _street;
    private string _city;
    private string _country;
    private string _number;
    
    
   
    //constructors
    public Address (string number, string street, string city, string country) 
    {
        _number = number;
        _street = street;
        _city = city;
        _country = country;

        
    }
 //getters setters

    public void SetStreet(string street)
    {
        _street = street;
    }

    public string GetStreet()
    {
        return _street;
    }
    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetCity()
    {
        return _city;
    }
     public void SetCountry(string country)
    {
        _country= country;
    }

    public string GetCountry()
    {
        return _country;
    }
    

    public string GetAddress()
    {
        return $"{_street}, {_number}, {_city}, {_country}";
    }

}
