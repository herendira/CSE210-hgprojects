using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Swimming: Activity
{
    
    private float _lapsnumber;
   
    //constructors
    public Swimming (float lapsnumber, string date, string actName, float time, float distance): base(date, actName, time, distance) 
    {
        _lapsnumber = lapsnumber;
    }

    //getters 

    public float GetLapsNumber()
    {
        return _lapsnumber;
    }
    public override float GetDis()
    {
        return (GetLapsNumber() * 50)/1000;
    }

    public override float GetRapidez()
    {
        float rapidez = (GetDis()/GetTime()) * 60;
        return (float)Math.Round(rapidez, 2);
    }
    public override float GetPaso()
    {
        return GetTime()/GetDis();
    }
    public override string GetSummary()
    {
        return $"{GetDate()} {GetActName()} ({GetTime()}) min: Distance: {GetDis()}km, Speed: {GetRapidez()} kph, Pace: {GetPaso()} min per km";
    }
    
}