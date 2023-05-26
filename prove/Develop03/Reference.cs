using System;
using System.Collections.Generic;
using System.IO;

class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _verse2;
    
//constructors
    public Reference()
    {
        _book="2 Nefi";
        _chapter="2";
        _verse="6";
       
    } 
    public Reference(string b,string c,string v1)
    {
        _book=b;
        _chapter=c;
        _verse=v1;
       
    }      
    public Reference(string b,string c,string v1,string v2)
    {
        _book=b;
        _chapter=c;
        _verse=v1;
        _verse2=v2;
    }   
    


//getters
public string GetReference()
{
    string refe=($"{_book} {_chapter}:{_verse}");
    return refe;
}

public string GetReference(string b, string c, string v1)
{
    string refe=($"{b} {c}:{v1}");
    return refe;
}

public string GetReference(string b, string c, string v1, string v2)
{
    string refe=($"{b} {c}:{v1}-{v2}");
    return refe;
}


public void Hide()
{
   
}
public void IsHidden()
{

}
public void Randomwords()
{

}
public void DisplayLines()
{

}





}


