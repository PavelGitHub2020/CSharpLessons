using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Geometric_Figure
{
    class CompositeFigure : AbstractGeometricFigure
    {
        public double side1, side2, side3;//обьявил здесь переменные, что бы не плодить лишние переменные в методе AddFigure
        private double base1, base2;
        private double height;
        private double radius;
        private double minorAxis, majorAxis;

        AbstractGeometricFigure[] figure;

        public CompositeFigure()
        {
            Console.WriteLine("Enter the number of geometric figure to create a composite figure:");

            int size = int.Parse(Console.ReadLine());

            figure = new AbstractGeometricFigure[size];
        }

        public void AddFigure()
        {
            for (int i = 0; i < figure.Length; i++)
            {
                Console.WriteLine("Which figure do you want to add?");
                Console.WriteLine("1 - Triangle");
                Console.WriteLine("2 - Trapezoid");
                Console.WriteLine("3 - Square");
                Console.WriteLine("4 - Rhombus");
                Console.WriteLine("5 - Rectangle");
                Console.WriteLine("6 - Parallelogram");
                Console.WriteLine("7 - Ellips");
                Console.WriteLine("8 - Circle");

                int choise = int.Parse(Console.ReadLine());

                switch(choise)
                {
                    case 1: 
                        Console.WriteLine("Enter the length of the sides of the triangle:");

                        side1 = double.Parse(Console.ReadLine());

                        side2 = double.Parse(Console.ReadLine());

                        side3 = double.Parse(Console.ReadLine());

                        Triangle triangle = new Triangle(side1, side2, side3);

                        triangle.Perimetr();

                        figure[i] = triangle;

                        break;

                    case 2:
                        Console.WriteLine("Enter the length of the firstBase/secondBase/height/firstSide/secondSide of the trapezoid:");

                        base1 = double.Parse(Console.ReadLine());

                        base2 = double.Parse(Console.ReadLine());

                        height = double.Parse(Console.ReadLine());

                        side1 = double.Parse(Console.ReadLine());

                        side2 = double.Parse(Console.ReadLine());

                        Trapezoid trapezoid = new Trapezoid(base1, base2, height, side1, side2);

                        figure[i] = trapezoid;

                        break;

                    case 3: 
                        Console.WriteLine("Enter the length of the side of the square:");

                        side1 = double.Parse(Console.ReadLine());

                        Square square = new Square(side1);

                        figure[i] = square;

                        break;

                    case 4: 
                        Console.WriteLine("Enter the length of the side/height of the rhombus:");

                        side1 = double.Parse(Console.ReadLine());

                        height = double.Parse(Console.ReadLine());

                        Rhombus rhombus = new Rhombus(side1, height);

                        figure[i] = rhombus;

                        break;

                    case 5:
                        Console.WriteLine("Enter the length of the side1/side2 of the rectangle:");

                        side1 = double.Parse(Console.ReadLine());

                        side2 = double.Parse(Console.ReadLine());

                        Rectangle rectangle = new Rectangle(side1, side2);

                        figure[i] = rectangle;

                        break;

                    case 6:
                        Console.WriteLine("Enter the length of the firstSide/secondSide/base/height of the parallelogram:");

                        side1 = double.Parse(Console.ReadLine());

                        side2 = double.Parse(Console.ReadLine());

                        base1 = double.Parse(Console.ReadLine());

                        height = double.Parse(Console.ReadLine());

                        Parallelogram parallelogram = new Parallelogram(side1, side2, base1, height);

                        figure[i] = parallelogram;

                        break;

                    case 7: 
                        Console.WriteLine("Enter the length of the minorAxis/majorAxis of the elleps:");

                        minorAxis = double.Parse(Console.ReadLine());

                        majorAxis = double.Parse(Console.ReadLine());

                        figure[i] = new Ellipse(minorAxis, majorAxis);

                        break;

                    case 8: 
                        Console.WriteLine("Enter the length of radius of the circle:");

                        radius = double.Parse(Console.ReadLine());

                        Circle circle = new Circle(radius);

                        figure[i] = circle;

                        break;

                    default:
                        Console.WriteLine("No such number, only from 1 to 8");

                        break;
                }
            }
        }

        public override  double Area()
        {
            for(int i = 0; i < figure.Length; i++)
            {
                area += figure[i].Area();
            }
            return area;
        }

        public override void Print()
        {
            Console.WriteLine("Area of the composite figure - " + area);
        }
    }
}