using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        fraction f1 = new fraction();
        //f1.GetDecimalValue();
        
        Console.WriteLine(f1.GetFraction());
        Console.WriteLine(f1.GetDecimalValue());
        
        fraction f2 = new fraction(5);
        //f2.GetDecimalValue();
        Console.WriteLine(f2.GetFraction());
        Console.WriteLine(f2.GetDecimalValue());
        

        fraction f3 = new fraction(3,4);
        //f3.GetDecimalValue();
        Console.WriteLine(f3.GetFraction());
        Console.WriteLine(f3.GetDecimalValue());
        

        fraction f4 = new fraction(1,3);
        Console.WriteLine(f4.GetFraction());
        Console.WriteLine(f4.GetDecimalValue());
        fraction f5 = new fraction(54,63);
         Console.WriteLine(f5.GetFraction());


    }
}