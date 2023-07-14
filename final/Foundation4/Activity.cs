using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

abstract class Activity
{
    //Constructors
    
    protected string _date;
    protected string _actName;
    protected float _time;
    protected float _distance;
    
    
    //constructors
    public Activity (string date, string actName, float time, float distance) 
    {
        _date = date;
        _actName = actName;
        _time = time;
        _distance = distance;
    }
    public Activity () 
    {
        _date = "";
        _actName = "";
        _time =0;
        _distance = 0;
    }
    //getters 


    public string GetDate()
    {
        return _date;
    }

    public float GetDistance()
    {
        return _distance;
    }

    public string GetActName()
    {
        return _actName;
    }
   

    public float GetTime()
    {
       return _time;
    }

   
    public abstract float GetDis();
    public abstract float GetRapidez();
    public abstract float GetPaso();
    public abstract string GetSummary();
    
}