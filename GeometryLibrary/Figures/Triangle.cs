using System;
using GeometryLibrary.Figures.Abstract;

namespace GeometryLibrary.Figures
{
    public class Triangle : ITwoDimensionFigures
    {
        public string Name => "Треугольник";
        private const int Angles = 3;

        private double _a, _b, _c;

        public double A => _a;

        public double B => _b;

        public double C => _c;
        public int FigureId { get; }
        public INamable.FigureType figureType => INamable.FigureType.Triangle;

        public int GetAnglesCount()
        {
            return Angles;
        }

        public Triangle(double a, double b, double c, int figureId)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double Area => throw new Exception("Не умею");
        public double Perimeter => _a + _b + _c;

        public double GetSquare()
        {
            return Area;
        }
    }
}