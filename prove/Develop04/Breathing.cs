using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;


class Breathing : Activity                     
{
    private string _in;
    private string _out;
    //private int _duration;
    
    
    
//Breathing constructors
     public Breathing()
    {
        _in="Breath in...";
        _out="Breath out...";
    } 
    public  Breathing(string breathin, string breathout)
    {
        _in= breathin;
        _out= breathout;
        //_duration= duration;

    } 
   


    //Breathing Getters
    public string GetBreathIn()
    {
      string bre=($"{_in}");
      return bre;
    }

    public string GetBreathOut()
    {
       string bre=($"{_out}");
       return bre;
    }
    
    public void BreathInOut(int segundos)
    {    
        Console.Clear();
       
       
        DateTime begin = DateTime.Now;
        DateTime finish = begin.AddSeconds(segundos);

        while(DateTime.Now < finish)
        {
            Console.WriteLine(GetBreathIn());
            base.Countdown();
            Console.WriteLine();
            Console.WriteLine(GetBreathOut());
            base.Countdown();
        }

    }
   

}