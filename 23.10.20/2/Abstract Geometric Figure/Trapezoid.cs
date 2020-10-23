using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Geometric_Figure
{
    class Trapezoid : AbstractGeometricFigure
    {
        private double firstBase;
        private double secondBase;
        private double height;
        private double firstSide;
        private double secondSide;

        public Trapezoid(double firstBase, double secondBase, double height, double firstSide, double secondSide)
        {
            this.firstBase = firstBase;
            this.secondBase = secondBase;
            this.height = height;
            this.firstSide = firstSide;
            this.secondSide = secondSide;
        }
        public override double Perimetr()
        {
            perimetr = firstBase + secondBase + firstSide + secondSide;

            return perimetr;
        }

        public override double Area()
        {
            area = ((firstBase + secondBase) / 2) * height;

            return area;
        }
    }
}
