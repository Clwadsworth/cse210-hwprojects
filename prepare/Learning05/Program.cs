using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating our universal list to hold all of our shapes with their assigned colors
        List<Shape> shapes = new List<Shape>();

        // Listing and stating all of our shapes and their attributes needed
        shapes.Add(new Square("Red", 3));
        shapes.Add(new Rectangle("Blue", 4, 5));
        shapes.Add(new Circle("Green", 6));

        // our loop for the program
        foreach (Shape s in shapes)
        {
            Console.WriteLine($"The {s.GetColor()} shape has an area of {s.GetArea()}.");
        }

    }
}