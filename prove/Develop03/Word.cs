using System;
using System.Collections.Generic;
using System.IO;

class Word                         //Class Word with all its members variables private
{   private List<int> _numderandom;
    private string _newwords;
   
    private string [] _word2= new string[]{};
    private string [] _word3= new string[]{};
   

    //Word Constructors
    public Word(string words)
    {
      _newwords=words;
    }
    

    public Word()
    {
     _word2= new string [] {};
     _word3= new string [] {};
     _numderandom= new List<int>();
        
    }

  

  //Word methods
public void ScripSplit()
{  
  
   Scripture scripture= new Scripture();
   string textoscrip=scripture.GetScripture();
   _word2=textoscrip.Split(" ");
  
  
}

public void ScripSplit2()
{ 
   Scripture scripture2= new Scripture();
   string textoscrip2=scripture2.GetScripture2();
   _word3=textoscrip2.Split(" ");
   
 
}


public void WordRandom()
{
    Random generator = new Random();
    for (int i = 0; i < _word2.Length; i++)
    {
         _numderandom.Add(i); 
    }

    Console.WriteLine("Press Enter to continue...");
    while ( _numderandom.Count > 0)
    {   
        Console.ReadLine(); 
         
        int randomIndex = generator.Next(0,  _numderandom.Count); 
        int wordIndex =  _numderandom[randomIndex]; 
        _word2[wordIndex] = new string('_', _word2[wordIndex].Length); 
        _numderandom.RemoveAt(randomIndex); 

        string _newwords = string.Join(" ", _word2); 
        Console.Clear();
        Console.WriteLine(_newwords); 
        
    }


}
public void WordRandom2()
{
    Random generator = new Random();
    for (int i = 0; i < _word3.Length; i++)
    {
         _numderandom.Add(i); 
    }
    Console.WriteLine("Press Enter to continue...");
    while ( _numderandom.Count > 0)
    {   
         Console.ReadLine(); 
        int randomIndex = generator.Next(0,  _numderandom.Count); 
        int wordIndex =  _numderandom[randomIndex]; 
        _word3[wordIndex] = new string('_', _word3[wordIndex].Length); 
        _numderandom.RemoveAt(randomIndex); 
        string _newwords = string.Join(" ", _word3); 
        Console.Clear();
        Reference reference=new Reference();  //Calling class Reference
        reference.GetReference();
        Console.WriteLine(_newwords); 
        
    }
}




}


  