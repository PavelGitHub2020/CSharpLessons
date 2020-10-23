using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Geometric_Figure
{
    class Ellipse : AbstractGeometricFigure
    {
        private double minorAxis;
        private double majorAxis;

        public Ellipse(double minorAxis, double majorAxis)
        {
            this.minorAxis = minorAxis;
            this.majorAxis = majorAxis;
        }
        public override double Perimetr()
        {
            perimetr = (4 * (Math.PI * minorAxis * majorAxis) + Math.Sqrt(majorAxis - minorAxis)) 
                / (majorAxis - minorAxis);

            return perimetr;
        }

        public override double Area()
        {
            area = Math.PI * minorAxis * majorAxis;

            return area;
        }
    }
}
