using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;


class Program
{
    static void Main(string[] args)
    {
    

    bool run = true;
      while(run)
      {
        Console.WriteLine("\n                                Welcome to MINDFULNESS Program");
        Console.WriteLine("\nMenu Options:\n1. Start Brething Activity\n2. Start Reflecting Activity\n3. Start Listing Activity\n4. Start Positive Activity\n5. Exit");
        string option = Console.ReadLine();
        switch(option)
        
        
       {
        case "1":
           
            Activity act = new Activity();
            Console.Clear();
            act.SetActName("Breathing");
            act.SetActAbout("This activity will help you relay by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
            Console.WriteLine(act.GetWelcome());
            act.MethodSpin();
            act.SetSecondes(act.MethodTimer());

            Breathing brea = new Breathing();
            brea.BreathInOut(act.GetSecondes());
           
            Console.WriteLine(act.MethodBye());
            

            

            break;

        case "2":
            
            Activity act2 = new Activity();
            Console.Clear();
            act2.SetActName("Reflecting");
            act2.SetActAbout("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
            Console.WriteLine(act2.GetWelcome());
        
            act2.MethodSpin();
            act2.SetSecondes(act2.MethodTimer());

            Reflecting reflec = new Reflecting();
            reflec.Reflectioning(act2.GetSecondes());
            
            Console.WriteLine(act2.MethodBye());
            
            break;


        case "3":
           
            Activity act3 = new Activity();
            Console.Clear();
            act3.SetActName("Listing");
            act3.SetActAbout("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certains area");
            Console.WriteLine(act3.GetWelcome());
            act3.MethodSpin();
            Listing listing = new Listing();
            act3.SetSecondes(act3.MethodTimer());
            listing.ListCore(act3.GetSecondes());
            Console.WriteLine(act3.MethodBye());
            
            break;

        case "4":
            
            Activity act4 = new Activity();
            Console.Clear();
            act4.SetActName("Positive");
            act4.SetActAbout("This activity will help you to increase your confidence. The things you say to yourself, play a big role in your actitude and in your Positivity.");
            Console.WriteLine(act4.GetWelcome());
            act4.MethodSpin();
            Positive positive = new Positive();
            act4.SetSecondes(act4.MethodTimer());
            positive.Confidence(act4.GetSecondes());
            Console.WriteLine(act4.MethodBye());
           
            break;


        case "5":
            Console.WriteLine("Your wellness es important...thanks for trusting  us");
            run=false;

            break;
        
        default:
            Console.WriteLine("Option no valid, read the menu well ");
            continue;
        }

        
      }

    }



}