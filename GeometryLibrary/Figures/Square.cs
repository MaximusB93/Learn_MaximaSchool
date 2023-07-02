using System;
using GeometryLibrary.Figures.Abstract;

namespace GeometryLibrary.Figures
{
    public class Square : ITwoDimensionFigures
    {
        public string Name => "Квадрат";
        private const int Angles = 4;
        private double _side;
        public double Side => _side;
        public int FigureId { get; }
        public INamable.FigureType figureType => INamable.FigureType.Square;

        public double Diagonal => Math.Sqrt(2) * _side;

        public double Area => Math.Pow(_side, 2);
        public double Perimeter => _side * 4;

        public Square(double side, int figureId)
        {
            this._side = side;
        }

        public int GetAnglesCount()
        {
            return Angles;
        }

        public double GetSquare()
        {
            return Area;
        }
    }
}