using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Address
{
    //Variables
    private string _street;
    private string _city;
    private string _country;
    private string _number;
    
    
   
    //Constructors
    public Address (string number, string street, string city, string country) 
    {
        _number = number;
        _street = street;
        _city = city;
        _country = country;

        
    }
    //getters 

    public string GetStreet()
    {
        return _street;
    }

    public string GetCity()
    {
        return _city;
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
