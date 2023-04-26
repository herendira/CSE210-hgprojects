using System;

using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
            
        List<int> numbers = new List<int>();
        
        
        int num = -1;
        while (num != 0)
        {
            Console.Write("Enter a number (0 to finish): ");
            
            string resp = Console.ReadLine();
            num = int.Parse(resp);
            
            // Only add the number to the list if it is not 0
            if (num != 0)
            {
                numbers.Add(num);
            }
        }

        // Sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        //Average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Max and Min
        int max = numbers[0];
        int min = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                
                max = number;
            }
            else if (number< max)
            {
                min= number;
            }
        }

        Console.WriteLine($"The max is: {max}");
        Console.WriteLine($"The min is: {min}");

        // sort
        Console.WriteLine("The sorted list is: ");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine($"{number}");
        }
        
    }
    
}