using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class Rectangle : Shape                  
{
    private double _lenght;
    private double _width;
    



    public Rectangle( double lenght, double width, string color): base( color)
    {
        _lenght = lenght;
        _width = width;
        
    } 

    public double GetLenght()
    {
         return _lenght;
    }
    public double GetWidth()
    {
         return _width;
    }

    public void SetWidth(double width)
    {
        _width = width;
    }

    public void SetLenght(double lenght)
    {
        _lenght = lenght;
    }



     public override double GetArea()
    {
        return _lenght*_width;
    }

}