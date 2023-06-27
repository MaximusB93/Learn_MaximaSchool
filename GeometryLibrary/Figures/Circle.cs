using System;
using GeometryLibrary.Figures.Abstract;

namespace GeometryLibrary.Figures
{
    [Authot("Максим", "27.09.2022")]
    public class Circle : ITwoDimensionFigures<int>
    {
        private const int _angles = 0;
        private double _r;


        public string Name => "Круг";
        public double R => _r;
        public double Diameter => _r * 2;
        public int FigureId { get; }
        public INamable<int>.FigureType figureType => INamable<int>.FigureType.Circle;

        public double Area => Math.PI * Math.Pow(_r, 2);
        public double Perimeter => 2 * Math.PI * _r;

        public Circle(double r, int figureId)
        {
            this._r = r;
        }

        public int GetAnglesCount()
        {
            return _angles;
        }

        public double GetSquare()
        {
            return Area;
        }
    }
}