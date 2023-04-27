using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess_number=-1;
        //int counting=0;
        string ans="yes";

        while (ans=="yes")
         {  
            int counting=0;
            while ((guess_number != number) && (ans=="yes"))
            {
              Console.Write("What is your guess? ");
              guess_number=int.Parse(Console.ReadLine());
              counting=counting+1;
              if (number > guess_number)
              {
                Console.WriteLine("Higher");
              }

              else if (guess_number< number)
              {
               Console.WriteLine("Lower");
              }

              else
              {
              Console.WriteLine("You guessed it!!");
              Console.WriteLine($"You tried {counting} times");
              counting=0;
              Console.Write("Do you want to play again? yes or not ");
              ans=Console.ReadLine();  
               }
            }
           
           
         }  
            
       
            
           if (ans=="not")
             {
               Console.WriteLine("Thanks for playing with me ");
             }
          else
          { ans="yes";
          }
         
      }  
         
}