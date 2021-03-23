using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Models
{
    class Rectangle : Shape
    {
        double width;
        double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        public override double GetArea()
        {
            return height * width;
        }
    }
}
