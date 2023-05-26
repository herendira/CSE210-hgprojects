using System;
using System.Collections.Generic;
using System.IO;

class Scripture             //Class scripture with all the members variables private
{
    private string _verse;
    private string[] _verse2= new string[] {}; 
    private string _verse3;
    private string [] _verse4= new string[] {}; 
    private string _verse5;  
   

   

    //Scripture Constructors
   public Scripture()
   {
      
       _verse= "\nAnd they sent and gathered together throughout all the land all the people, and consulted with them concerning the words which had been spoken.Now their rulers and their priests and their teachers did not let the people know concerning their desires;therefore they found out privily the minds of all the people.\n";
       _verse5="\nWherefore, I, Lehi, prophesy according to the workings of the Spirit which is in me,that there shall anone come into this land save they shall be brought by the hand of the Lord.\n";
   
   
   }


   public Scripture(string verse3)
   {
    _verse3= verse3;
    _verse4= new string [] {};
    
   }

  
   
   //Scripture getters
   public string GetScripture()
   {
    string wholescrip=($"{_verse}");
    return wholescrip;
   }

   public string GetScripture2()
   {
    string wholescrip2=($" {_verse5}");
    return wholescrip2;
   }


  } 