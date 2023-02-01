using System;

public class Program
{
    static void Main(string[] args)
    {
          Square square = new Square("Red", 4);
          Console.WriteLine("Color: " + square.Color);
          Console.WriteLine("Area: " + square.GetArea());

          // Repeat the same steps for Rectangle and Circle classes

          List<Shape> shapes = new List<Shape>();
          shapes.Add(new Square("Green", 5));
          shapes.Add(new Rectangle("Blue", 4, 6));
          shapes.Add(new Circle("Yellow", 5));

          foreach (var shape in shapes)
            {
                Console.WriteLine("Color: " + shape.Color);
                Console.WriteLine("Area: " + shape.GetArea());
             }
            
    }
}