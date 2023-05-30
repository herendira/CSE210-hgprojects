using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");
        Assignment assignment = new Assignment("Herendira Gomez", "Classes C");
        Console.WriteLine(assignment.GetSummary());

        MathAssig mathassig = new MathAssig("Roberto Rodriguez", "Fractions","Section 7.3", "Problems 8-19");
        Console.WriteLine(mathassig.GetSummary());

        Console.WriteLine(mathassig.GetHomeworkList());
        WritingAssig writing =new WritingAssig("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritAssig());

    }
}