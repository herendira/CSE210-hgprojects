using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class Activity                    
{
    protected int _segundos;
    protected string _actName;
    protected string _actAbout;
   

    public  Activity()
    {
       _actName =" ";
       _actAbout = " ";
      
    } 

    public  Activity(string actName, string actAbout, int segundos)
    {
       _actName = actName;
       _actAbout = actAbout;
       _segundos = segundos;
       
    } 

    
    public int GetSecondes()
    {
      return _segundos;
    }

    public void SetSecondes(int segundos)
    {
      _segundos = segundos;
    }

    

    public string GetActName()
    {
       return _actName;
    }
    
    public string GetActAbout()
    {
       
       return _actAbout;
    }

    public void SetActName(string actName)
    {
       _actName = actName;
    }

    public void SetActAbout(string actAbout)
    {
       _actAbout = actAbout;
    }


    public string GetWelcome()
    {
      return $"Welcome to the {_actName} activity\n{_actAbout}";
    }

    
    public void MethodSpin()
    {
      Console.WriteLine("Get ready");
      List<string> animation = new List<string>();
      animation.Add("|");
      animation.Add("/");
      animation.Add("-");
      animation.Add("\\");
      animation.Add("|");
      animation.Add("/");
      animation.Add("-");
      animation.Add("\\");
      

      foreach (string a in animation)
      {
        Console.Write(a);
        Thread.Sleep(250);
        Console.Write("\b \b");
      }

    }

    public string MethodBye()
    {
      return ($"You have completed another {_segundos} sec of {_actName} Activity. ");
    }
    public int MethodTimer()
    {
      Console.WriteLine("How long in seconds, would you like for your session? Ex. 10,20,30");
      _segundos = int.Parse(Console.ReadLine());
      return _segundos;
    }

   
        
    protected void Countdown()
    {
      for(int i = 5; i>0; i--)
     {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
       
        
      }
    }


}