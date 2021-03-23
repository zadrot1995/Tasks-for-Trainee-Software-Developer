using System;
using System.Collections.Generic;
using Task2.Models;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>{ new Square(5),
                                          new Circle(5),
                                          new Triangle(3, 4, 5) };
            shapes.Sort();
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }
        }
    }
}
