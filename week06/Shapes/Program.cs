using System;
using System.Collections.Generic; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Green", 4);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Blue", 2, 3);
        shapes.Add(rectangle);

        Circle circle = new Circle("Red", 2);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Shape Color: {color}, Area: {area}");
        }
    }
}