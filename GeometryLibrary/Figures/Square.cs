using System;
using GeometryLibrary.Figures.Abstract;

namespace GeometryLibrary.Figures
{
    public class Square : ITwoDimensionFigures<string>
    {
        private const int Angles = 4;
        private double _side;
        
        public string Name => "Квадрат";
        public double Side => _side;
        public string FigureId { get; }
        public INamable<string>.FigureType figureType => INamable<string>.FigureType.Square;

        public double Diagonal => Math.Sqrt(2) * _side;

        public  double Area => Math.Pow(_side, 2);
        public  double Perimeter => _side * 4;

        public Square(double side, string figureId) 
        {
            this._side = side;
        }

        public  int GetAnglesCount()
        {
            return Angles;
        }

        public double GetSquare()
        {
            return Area;
        }
    }
}