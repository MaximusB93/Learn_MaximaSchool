using System;
using System.Drawing;

namespace CreatureCarAndHuman
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