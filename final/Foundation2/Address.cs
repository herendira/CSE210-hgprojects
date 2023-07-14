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
    private float _shipping;
    
   
    //constructors
    public Address(string street, string city, string country)
    {
        _street = street;
        _city = city;
        _country = country;
    }

    public Address(float shipping)
    {
        _shipping = shipping;
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
     public float GetShipping()
    {
        return _shipping;
    }
    
    //Methods
    public float EUorNot()
    {
        if(_country == "USA")
        {
            _shipping = 5;
        }    
        else
        {
            _shipping = 35;
        }    
        
        return _shipping;
    }

    public string GetFullAdress()
    {
        StringBuilder completeAddress = new StringBuilder();
        completeAddress.AppendLine($"Street: {_street}");
        completeAddress.AppendLine($"City: {_city}");
        completeAddress.AppendLine($"Country: {_country}");

        return completeAddress.ToString();
    }

}
