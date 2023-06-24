using System;
using System.Collections.Generic;
using System.IO;

class Eternal : Goal
{
   //Constructors 
   public Eternal(string name, string description, int points, int eventpoints, bool iscomplete) : base(name, description, points, eventpoints, iscomplete)
    {
    }
    public Eternal()
    {

    }

    
    public override int RecordEvent()
    {
        return _points;
    }

    public override string Serialize()
    {

        return $"Eternal,{this._name},{this._description},{this._points},{this._eventpoints},{this._iscomplete}";
    }


}