using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Geometric_Figure
{
    class Circle : AbstractGeometricFigure
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Perimetr()
        {
            perimetr = 2 * Math.PI * radius;

            return perimetr;
        }

        public override double Area()
        {
            area = Math.PI * (radius * radius);

            return area;
        }
    }
}
