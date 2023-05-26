using System;

class Program
{
    static void Main(string[] args)
   {     
        
        Console.WriteLine(" \n\n\n             S C R I P T U R E    M E M O R I Z E       \n");
       
        bool op = true;
        while (op)
        {
            Console.WriteLine("Enter to continue");
            Console.WriteLine("Write quit to finish\n");
            string option= Console.ReadLine();
            if (option=="")
              {    
                  //Reference and Scripture instances
                  Console.WriteLine("Option A");
                  Reference reference2 = new Reference();
                  Console.WriteLine(reference2.GetReference("2 Nefi","2","6"));
                  Scripture scripture = new Scripture();
           
                  Console.WriteLine(scripture.GetScripture());
                  Console.WriteLine("\n\n");



                  Console.WriteLine("Option B");
                  Reference reference3 = new Reference();
                  Console.WriteLine(reference3.GetReference("Alma","35","4","5"));
                  Scripture scripture2 = new Scripture();
                  Console.WriteLine(scripture2.GetScripture2());
                  Console.WriteLine("\n\n");
                  Word word = new Word();

                  Console.WriteLine("What Scripture would you like to learn? A or B");
                  string quiero=Console.ReadLine();
                  if (quiero=="A")
                  {  
                     Console.WriteLine(reference2.GetReference("2 Nefi","2","6"));
                     Console.WriteLine(scripture.GetScripture());
                     Console.WriteLine("\nReady??? GO!!! press enter to continue\n");
                     word.scripsplit();
                     Console.WriteLine(reference2.GetReference("2 Nefi","2","6"));
                     word.wordrandom();
                  }
                  if (quiero=="B")
                  { 
                    Console.WriteLine(reference3.GetReference("Alma","35","4","5"));
                    Console.WriteLine(scripture2.GetScripture2());
                    Console.WriteLine("\nReady??? GO!!! press enter to continue\n");
                    word.scriptsplit2();
                    Console.WriteLine(reference3.GetReference("Alma","35","4","5"));
                    word.wordrandom2();
                }
              }

                  

              
               
            else if (option == "quit")
                {
                  Console.WriteLine("Keep going learning the Scriptures");
                  op=false;
                }
            else
               {
                Console.WriteLine("Select enter to continue, or quit to finish");
                continue;
               }  
             }  
            

    
   
    
   } 

  
 
}