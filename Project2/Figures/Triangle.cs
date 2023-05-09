using System;
using System.Linq.Expressions;

namespace Project2.Figures
{
    public class Triangle : Figure
    {
        private double _a, _b, _c;

        public double A => _a;

        public double B => _b;

        public double C => _c;
        public override FigureType FigureType => FigureType.Triangle;

        public Triangle(double a, double b, double c, int figureId) : base(figureId)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public override double Area => throw new Exception("Не умею");
        public override double Perimeter => _a + _b + _c;
    }
}