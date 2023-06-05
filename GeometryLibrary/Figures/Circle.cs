using System;
using GeometryLibrary.Figures.Abstract;

namespace GeometryLibrary.Figures
{
    public class Circle : TwoDimensionFigures
    {
        private const int Angles = 0;
        private double _r;

        public double R => _r;
        public double Diameter => _r * 2;
        public override FigureType FigureType => FigureType.Circle;

        public override double Area => Math.PI * Math.Pow(_r, 2);
        public override double Perimeter => 2 * Math.PI * _r;

        public Circle(double r, int figureId) : base( figureId)
        {
            this._r = r;
        }
        
        public override int GetAnglesCount()
        {
            return Angles;
        }
        
    }
}