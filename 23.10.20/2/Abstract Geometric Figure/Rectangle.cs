using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Geometric_Figure
{
    class Rectangle : AbstractGeometricFigure
    {
        private double sideA;
        private double sideB;

        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public override double Perimetr()
        {
            perimetr = 2 * (sideA + sideB);

            return perimetr;
        }

        public override double Area()
        {
            area = sideA * sideB;

            return area;
        }
    }
}
