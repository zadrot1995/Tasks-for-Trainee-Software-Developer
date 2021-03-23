using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Models
{
    public abstract class Shape: IComparable
    {
        public int CompareTo(object obj)
        {
            if (this.GetArea() > ((Shape)obj).GetArea())
            {
                return 1;
            }
            if (this.GetArea() == ((Shape)obj).GetArea())
            {   
                return 0;
            }
            else
            {
                return -1;
            }

        }

        public abstract double GetArea();
    }
}
