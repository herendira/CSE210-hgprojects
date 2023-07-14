using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Running: Activity
{
    
    private float _rundistance;
   
    //constructors
    public Running (float rundistance, string date, string actName, float time, float distance): base(date, actName, time, distance) 
    {
        _rundistance = rundistance;
    }

    //getters 

    public float GetRundistance()
    {
        return _rundistance;
    }

    //Overrides Methods
    public override float GetDis()
    {
        return _rundistance;
    }
    public override float GetRapidez()
    {
        float rap = (GetDis()/ GetTime())*60;
        return (float)Math.Round(rap, 2);
    }
    public override float GetPaso()
    {
        float pasito = GetTime()/GetDis();
        return (float)Math.Round(pasito, 2);
    }
    public override string GetSummary()
    {
         return $"{GetDate()} {GetActName()} ({GetTime()}) min: Distance: {GetDis()} miles, Speed: {GetRapidez()} mph, Pace: {GetPaso()} min per mile";
    }
    
   
}