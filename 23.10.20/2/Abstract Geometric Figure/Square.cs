using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Geometric_Figure
{
    class Square : AbstractGeometricFigure
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override double Perimetr()
        {
            perimetr = 4 * side;

            return perimetr;
        }

        public override double Area()
        {
            area = side * side;

            return area;
        }
    }
}
