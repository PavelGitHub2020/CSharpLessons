using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Geometric_Figure
{
    abstract class AbstractGeometricFigure
    {
        protected double perimetr;
        protected double area;
        public virtual double Perimetr() { return perimetr; }

        public virtual double Area() { return area; }

        public virtual void Print() 
        {
            Console.WriteLine("Perimetr - " + perimetr);

            Console.WriteLine("Area - " + area);
        }
    }
}
