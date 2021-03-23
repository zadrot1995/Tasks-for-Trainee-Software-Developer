using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Models
{
    class Triangle : Shape
    {
        double a;
        double b;
        double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public override double GetArea()
        {
            return a*b/2;
        }
    }
}
