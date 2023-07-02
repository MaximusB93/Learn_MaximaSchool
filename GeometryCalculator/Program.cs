using System;
using GeometryLibrary.Figures;
using GeometryLibrary.Figures.Abstract;

namespace GeometryCalculator
{
    class Program
    {
        static void Main()
        {
            ITwoDimensionFigures rectangle = new Rectangle(4, 5);

            double areaRectangle = rectangle.GetSquare();
            string name = rectangle.Name;
            Console.WriteLine($"Площадь {name} - {areaRectangle}");
        }
    }
}