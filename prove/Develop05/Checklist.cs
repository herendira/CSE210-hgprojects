using System;
using System.Collections.Generic;
using System.IO;

class Checklist : Goal
{


    protected int _manytime;
    protected int _counter;

    //Constructors
    public Checklist()
    {

    }


    public Checklist(string name, string description, int points, int manytimes, int eventpoints, bool iscomplete, int counter) : base(name, description, points, eventpoints, iscomplete)
    {
        _counter = counter;
        _manytime = manytimes;
    }

    public void SetManyTimes(int manytimes)
    {
        _manytime = manytimes;
    }

    public int GetManytimes()
    {
        return _manytime;
    }

    public override int RecordEvent()
    {
        _counter += 1;
        if (_counter == _manytime)
        {
            this._iscomplete = true;
            return _eventpoints;
        }

        return _points;
    }


    public override string Serialize()
    {

        return $"Checklist,{this._name},{this._description},{this._points},{this._manytime},{this._eventpoints},{this._iscomplete},{this._counter}";
    }

    public override string GetDisplayMessage()
    {
        var completedText = IsComplete() ? "X" : " ";
        return $"[{completedText}] {GetName()}, {GetPoints()} {this._counter}/{this._manytime}";
    }

}