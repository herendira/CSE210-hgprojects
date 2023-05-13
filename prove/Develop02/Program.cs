using System;
using System.IO;
using System.Collections.Generic;

using System;

class Program
{
    static void Main(string[] args)
    {
      //File file=new File();
      Journal journal=new Journal();
      Console.WriteLine("                    \n\nWelcome\n\n    Writing my day with JOji!!\n\n");
      bool run = true;
      while(run)
      {
        
        //journal.menu();
        Console.WriteLine("Please select one of the following choices:\n");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n\n");
        Console.Write("Option? ");
        int option = int.Parse(Console.ReadLine());
        //Console.Clear();
        switch(option)
        
        
       {
        case 1:


            string _prompt = journal.prompts();
            Console.WriteLine("");
            
            Console.Write(_prompt);
            journal._Prompt = _prompt;
            Console.WriteLine("");
            journal.Write();
            journal._EntryText = Console.ReadLine();
            journal._Date = journal.timeEntry();
            Console.WriteLine("");
            //journal.Write();


            break;

        case 2:
            journal.Display();

            break;

        case 3:
            FileJournal.readFromFile();
            break;
        case 4:
            Console.WriteLine("Saving...");
            FileJournal.SaveToCsv(journal.journallist);
            Console.WriteLine("Completed");
            break;
        case 5:
            Console.WriteLine("Thanks for writing with JOji ");
            run=false;
            break;
        
        default:
            Console.WriteLine("Option no valid, read the menu well ");

            continue;
        }

        
      }
   }
}   