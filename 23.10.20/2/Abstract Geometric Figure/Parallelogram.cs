using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Geometric_Figure
{
    class Parallelogram : AbstractGeometricFigure
    {
        private double firstSide;
        private double secondSide;
        private double base_1;
        private double height;

        public Parallelogram(double firstSide, double secondSide, double base_1, double height)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.base_1 = base_1;//основание
            this.height = height;
        }

        public override double Perimetr()
        {
            perimetr = 2 * (firstSide + secondSide);

            return perimetr;
        }

        public override double Area()
        {
            area = base_1 * height;

            return area;
        }
    }
}
