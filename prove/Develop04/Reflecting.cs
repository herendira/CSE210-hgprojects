using System;
using System.Collections.Generic;
using System.IO;

class Reflecting : Activity                     
{
    private string _prompt;
    private string _question;
   // private List<string> _promptsRef;
   // private List<string> _questionsRef;
    protected string[] _questions;
    protected string[] _prompts;

    public Reflecting()
    {
        _prompt="";
        _question="";
       // _questionsRef= new List<string>();
        //_promptsRef= new List<string>();
        _questions = new string [] {"What did you do?",
                                   "Where did you start?",
                                   "How did you find the answer",
                                   "Who was with you?"};
        _prompts = new string[] {"Think of a time when you did something hard.",
                                 "Think when you got the results you searched.",
                                 "Remember that day when your pray was answered."};

    } 
    public void SetPrompts(string[] prompts)
    {
        _prompts= prompts;
    }
    public void SetQuestions(string[] questions)
    {
        _questions= questions;
    }


    public string GetPro()
    {
        string prom=($"{_prompt}");
        return prom;
    }
    
    public string GetQue()
    {
        string ques=($"{_question}");
        return ques;
    }

    public string RandomPro()
    {
        
        Random random = new Random();
        int index = random.Next(0, _prompts.Length);
        _prompt = _prompts[index];
        
        return _prompt;
        
    }
    public string RandomQue()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Length);
        _question = _questions[index];
        return _question;
    }

    public void Reflectioning(int segundos)
    {   
        Console.Clear();
        Console.WriteLine("Consider the following prompt");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(RandomPro());
        Console.ResetColor();
        Console.WriteLine("When you something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        
        base.Countdown();
       
        DateTime begin = DateTime.Now;
        DateTime finish = begin.AddSeconds(segundos);

        while(DateTime.Now < finish)
        {
            Console.WriteLine(RandomQue());
            base.Countdown();
            
        }
        Console.WriteLine("Well done!! ");
    }
   

    

  
    

    




   
}