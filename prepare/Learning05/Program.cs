using System;

class Program
{
    static void Main(string[] args)
    {
       
       List<Shape>shapes = new List<Shape>();

       Square square = new Square(5,"pink");
       square.GetArea();
       shapes.Add(square);
       


       Circle circle = new Circle(15, "red");
       circle.GetArea();
       shapes.Add(circle);


       Rectangle rectangle = new Rectangle( 10, 20, "blue");
       rectangle.GetArea();
       shapes.Add(rectangle);

       Display(circle);
       Display(rectangle);
       Display(square);
       
       foreach (Shape f in shapes)
       {
        string color = f.GetColor();
        double area = f.GetArea();
        Console.WriteLine($"The {color} shape has an area of {area}.");
       }

    }
    public static void Display(Shape s)
       { 
            double area =s.GetArea();
            string color= s.GetColor();
           
            Console.WriteLine($"{color}, area: {area}m2");

       }
}