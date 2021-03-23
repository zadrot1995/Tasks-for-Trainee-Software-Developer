using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Models
{
    class Square : Shape
    {
        double side;

        public Square(double side)
        {
            this.Side = side;
        }

        public double Side { get => side; set => side = value; }

        public override double GetArea()
        {
            return Side * Side;
        }
    }
}
