using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Models
{
    class Circle : Shape
    {
        double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
