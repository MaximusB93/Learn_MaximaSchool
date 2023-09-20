using System;
using GeometryLibrary.DirAttribute;
using GeometryLibrary.Figures.Abstract;

namespace GeometryLibrary.Figures
{
    [Author("Maksim", "20.09.2023")]
    public class Triangle<T> : ITwoDimensionFigures<T>
    {
        private const int Angles = 3;

        private double _a, _b, _c;

        public string Name => "Треугольник";
        public double A => _a;
        public double B => _b;
        public double C => _c;
        public T FigureId { get; }
        public INamable<T>.FigureType figureType => INamable<T>.FigureType.Triangle;

        public int GetAnglesCount()
        {
            return Angles;
        }

        public Triangle(double a, double b, double c, T figureId)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double Area => throw new Exception("Не умею");
        public double Perimeter => _a + _b + _c;

        [Custom("Получение площади квадрата")]
        public double GetSquare()
        {
            return Area;
        }
    }
}