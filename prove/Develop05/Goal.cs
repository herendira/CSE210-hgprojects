using System;
using System.Collections.Generic;
using System.IO;

class Goal
{

    protected string _name;

    protected string _description;
    public int _points;
    protected int _eventpoints;
    protected bool _iscomplete;



    public Goal()
    {

        _name = " ";
        _description = " ";
        _points = 0;
    }

    //Constructors

    public Goal(string name, string description, int points, int eventpoints, bool iscomplete)
    {

        _name = name;
        _description = description;
        _points = points;
        _eventpoints = eventpoints;
        _iscomplete = iscomplete;

    }


    // Gettters and Setters

    public int GetEventPoints()
    {
        return _eventpoints;
    }

    public void SetEventPoints(int eventpoints)
    {
        _eventpoints = eventpoints;
    }
    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public virtual int RecordEvent()
    {
        return 0;
    }
    public virtual bool IsComplete()
    {
        return _iscomplete;
    }

    public virtual string GetDisplayMessage()
    {
        var completedText = IsComplete() ? "X" : " ";
        return $"[{completedText}] {GetName()}, {GetPoints()}";
    }









    public virtual string Serialize()
    {
        return null;
    }



    
      





}