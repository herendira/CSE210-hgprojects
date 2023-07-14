using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


class Cycling: Activity
{
    
    protected float _cyspeed;
   
    //constructors
    public Cycling (float cyspeed, string date, string actName, float time, float distance): base(date, actName, time, distance)
    {
        _cyspeed = cyspeed;
    }

     //getters

    public float GetCyspeed()
    {
        return _cyspeed;
    }

    //Override Methods
    public override float GetDis()
    {
        return 0;
    }
    public override float GetRapidez()
    {
        return _cyspeed;
    }
    public override float GetPaso()
    {
        float paso = 60/GetRapidez();
        return (float)Math.Round(paso,2);
    }

    public override string GetSummary()
    {
        return $"{GetDate()} {GetActName()}({GetTime()}) min: Speed {GetRapidez()} mph, Pace: {GetPaso()} min per mile";
    }
    
   
}
