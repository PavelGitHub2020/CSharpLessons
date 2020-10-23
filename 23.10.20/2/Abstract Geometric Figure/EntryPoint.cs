using System;

namespace Abstract_Geometric_Figure
{
    class EntryPoint
    {
        //Разработать абстрактный класс Геометрическая фигура с методами Площадь фигуры и 
        //Периметр фигуры.Разработать классы-наследники:Треугольник, Квадрат, Ромб, Прямоугольник,
        //Параллелограмм, Трапеция, Круг, Эллипс.Реализовать конструкторы которые однозначно
        //определяют обьекты данных классов.

        //Реализовать класс Составная фигура, который может 
        //состоять из любого кол-ва Геометрических фигур.
        //Для данного класса определить метод нахождения 
        //площади фигуры. Создать диаграмму отношений классов.
        static void Main(string[] args)
        {
           
                Triangle triangle = new Triangle(2.4, 5.6, 7.9);
                triangle.Perimetr();
                triangle.Area();
                triangle.Print();
                Console.WriteLine();

                Square square = new Square(12.5);
                square.Perimetr();
                square.Area();
                square.Print();
                Console.WriteLine();

                Rhombus rhombus = new Rhombus(2.5, 3.5);
                rhombus.Perimetr();
                rhombus.Area();
                rhombus.Print();
                Console.WriteLine();

                Rectangle rectangle = new Rectangle(3.4, 6.7);
                rectangle.Perimetr();
                rectangle.Area();
                rectangle.Print();
                Console.WriteLine();

                Parallelogram parallelogram = new Parallelogram(2.4, 5.6, 4.4, 7.8);
                parallelogram.Perimetr();
                parallelogram.Area();
                parallelogram.Print();
                Console.WriteLine();

                Trapezoid trapezoid = new Trapezoid(6.8, 3.7, 5.3, 4.2, 5.1);
                trapezoid.Perimetr();
                trapezoid.Area();
                trapezoid.Print();
                Console.WriteLine();

                Circle circle = new Circle(5.2);
                circle.Perimetr();
                circle.Area();
                circle.Print();
                Console.WriteLine();

                Ellipse ellipse = new Ellipse(4.6, 8.9);
                ellipse.Perimetr();
                ellipse.Area();
                ellipse.Print();
                Console.WriteLine();

            try
            {

                CompositeFigure compositeFigure = new CompositeFigure();
                compositeFigure.AddFigure();
                compositeFigure.Area();
                compositeFigure.Print();
            }
            catch (Exception)
            {
                Console.WriteLine("You entered incorrect data");
            }
           
           
           
           
        }

    }
}
