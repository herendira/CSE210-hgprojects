using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class Circle : Shape                  
{
    private double _radius;
    

    public Circle( double radius, string color): base(color)
    {
        _radius=radius;
       
    } 

    public double GetRadius()
    {
         return _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

     public override double GetArea()
    {
        return 3.1416*(_radius*_radius);
    }

}