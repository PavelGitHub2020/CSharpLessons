using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Geometric_Figure
{
    class Rhombus : AbstractGeometricFigure
    {
        private double side;
        private double height;

       public Rhombus(double side, double height)
       {
            this.side = side;
            this.height = height;
       }

        public override double Perimetr()
        {
            perimetr = 4 * side;

            return perimetr;
        }

        public override double Area()
        {
            area = side * height;

            return area;
        }
    }
}
