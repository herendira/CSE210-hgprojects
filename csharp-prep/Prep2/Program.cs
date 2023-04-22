using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        
        Console.Write("What is your percentage? (0-100) ");
        string user_perc=Console.ReadLine();
        int grade=int.Parse(user_perc);
        
        string lettre = " ";

        if (grade>=90)
        { 
            lettre="A";
        }
        else if (grade>=80)
        {
            lettre="B";
        }
        else if (grade>=70)
        {
            lettre="C";
        }
        else if (grade>=60)
        {
            lettre="D";
        }
        else
        {
            lettre="F";
        }

        

        int grade2;
        grade2=grade%10;
        string signo="";

        if (grade2>=7)
           {
             signo="+";
           } 
        else if (grade2<3)
           {
            signo="-";
           }
        else
        {
            signo= "";
        }

        if (lettre=="A" && signo=="+")
        {
            Console.WriteLine($"Your grade is: {lettre}");
        }

        Console.WriteLine($"Your lettre grade is: {signo}{lettre}. ");
        
        if (grade>=70)
            {
                Console.WriteLine("Congratulations!! You have passed the cours.");
            } 
        else if (grade<70)
            {
                Console.WriteLine("You have not passed the cours, Keep trying!!");
            }  
    }


}