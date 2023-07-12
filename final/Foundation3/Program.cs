using System;

class Program
{
    static void Main(string[] args)
    {   //*****Create Lecture Event*****
        Address ad = new Address("451","Boulevard Sun Light", "Miami, Florida", "EUA");
        ad.GetAddress();
        Lecture l = new Lecture("Lecture","Friend to Friend","Follow the good path to reach all your objectives.","July 20, 2023","18:30", ad,"Evan McEvan","25 places");
        //Lecture Short
        Console.WriteLine(l.GetShort());
        Console.WriteLine();
         //Lecture  Standard
        Console.WriteLine(l.GetStandard());
        Console.WriteLine();
         //Lecture Full Detail
        Console.WriteLine(l.GetEvent());
        Console.WriteLine(l.GetStandard());

        //*****Create Reception Event****
        Address ad2 = new Address("5689","Rue Sevigny", "Quebec, Qc", "Canada");
        ad2.GetAddress();
        Reception r = new Reception("Reception","Creating my own Business","The correct way to make a success business","July 25, 2023","10:30", ad2,"MyBussiness@byui.com");
        //Reception Short
        Console.WriteLine(r.GetShort());
        Console.WriteLine();
         //Reception Standard
        Console.WriteLine(r.GetStandard());
        Console.WriteLine();
         //Reception Full Detail
        Console.WriteLine(r.GetEvent());
        Console.WriteLine(r.GetStandard());
        
        //*****Create Outdoor Event****
        Address ad3 = new Address("57A","Calle Maribel", "Saltillo, Coah.", "Mexico");
        ad3.GetAddress();
        Outdoor o1 = new Outdoor();
        
        Outdoor o = new Outdoor("Outdoor","Water from underground rivers","Water: the biggest problem in northern Mexico, there is hope in the subsoil","July 30, 2023","11:30", ad3, o1.GetWeather());
        //Outdoor Short
        Console.WriteLine(o.GetShort());
        Console.WriteLine();
         //Outdoor Standard
        Console.WriteLine(o.GetStandard());
        Console.WriteLine();
         //Outdoor Full Detail
        Console.WriteLine(o.GetEvent());
        Console.WriteLine(o.GetStandard());
    }
}