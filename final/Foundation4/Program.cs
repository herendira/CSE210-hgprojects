using System;

class Program
{
    static void Main(string[] args)
    {
        
        List <Activity> acts = new List<Activity>();
        
        Cycling c = new Cycling(7.5f, "03 July 2023", "Cycling", 20f , 2.6f);
        acts.Add(c);
        Swimming s = new Swimming(5f, "10 May 2023", "Swimming", 120f, 3.0f );
        acts.Add(s);
        Running r = new Running(4.5f, "25 March 2023", "Running", 70f, 1.23f );
        acts.Add(r);

        foreach(Activity a in acts)
        {
            Console.WriteLine();
            Console.WriteLine(a.GetSummary());
            Console.WriteLine();
        }

    }
}