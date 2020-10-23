using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Geometric_Figure
{
    class Triangle : AbstractGeometricFigure
    {
        private double sideA;
        private double sideB;
        private double sideC;
        private double poluperimetr;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public override double Perimetr() 
        {
            perimetr = sideA + sideB + sideC;

            return perimetr;
        }

        public override double Area()
        {
            poluperimetr = perimetr / 2;

            area = Math.Sqrt( poluperimetr * (poluperimetr - sideA) * (poluperimetr - sideB) * (poluperimetr - sideC));

            return area;
        }

    }
}
