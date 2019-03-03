using System;
using AreaCalculator.Figures;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Площадь круга
            Console.WriteLine($"Площадь круга с радиусом 10 = { new Circle(10).CalculateArea()}\r\n" );

            // Площадь треугольника
            Console.WriteLine($"Площадь треугольника со сторонами 3, 4, 5 = { new Triangle(3, 4, 5).CalculateArea() }\r\n");

            // Проверка, прямоугольный ли треугольник
            Console.WriteLine($"Треугольник со сторонами 3, 4, 5 прямоугольный? { new Triangle(3, 4, 5).IsRightTriangle }\r\n");

            // Вычисление площади, не зная типа фигуры
            Figure.Create(10, 20, 30).CalculateArea();
        }
    }
}
