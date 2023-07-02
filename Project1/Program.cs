using System;
using System.Drawing;
using GeometryLibrary.Figures.Abstract;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(car);

            GeometricFigure geometricFigure = new GeometricFigure(20, 30, 15);
            Console.WriteLine(geometricFigure.Square);
            
        }
    }
}