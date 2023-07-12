using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Outdoor:Event
{

    private string _weather;
    private List<string> weather;
    
    
   
    //constructors
    public Outdoor()
    {
      
    }
    public Outdoor(string type, string title, string description, string date, string time, Address address, string weather):base(type, title, description, date, time, address)
    {
        _weather = weather;
        

    }

     public void SetWeather(string weather)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    // Methods
    public string WeatherRandom()
    {
        var random = new Random();
        weather = new List<string>{"Sunny 15 degrees","Cloudy 10 degrees","Rainy 25 degrees","Sunny 15 degrees"};
        
        int index = random.Next(weather.Count);
        return weather[index];
    }
    public override string GetEvent()
    {
        return $"{base.GetEvent()}\nWeather: {WeatherRandom()}";
    }

    
} 