using System;

class Program
{
    static void Main(string[] args)
    {
        Welcome();

        string name = UserName();
        int number = UserNumber();
        int square= Numsquare(number);

        Results(name, square);
    }
     static void Welcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string UserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int UserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int Numsquare(int number)
    {
        int square = number * number;
        return square;
    }

    static void Results(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}