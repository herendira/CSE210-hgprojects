using System;
using System.Collections.Generic;
using System.IO;

class Simple : Goal                    
{
    //Constructors
    public Simple ()
    {
    }

    public Simple(string name, string description, int points, bool iscomplete):
     base(name, description, points, 0, iscomplete)
    {
    }

    
    
    
    public override int RecordEvent()
    {
        this._iscomplete = true;
        return _points;
    }

    public override string Serialize() 
    {
        return $"Simple,{this._name},{this._description},{this._points},{this._iscomplete}";
    }

    
    
}