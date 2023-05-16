using System;
using System.Linq.Expressions;

namespace Library1.Figures
{
    public class Triangle : Figure
    {
        private const int Angles = 3;
        
        private double _a, _b, _c;

        public double A => _a;

        public double B => _b;

        public double C => _c;
        public override FigureType FigureType => FigureType.Triangle;

        public override void GetAnglesCount()
        {
            return Angles;
        }

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