using System;

namespace GeometryLibrary.Figures
{
    public class Square : Figure
    {
        private const int Angles = 4;
        private double _side;
        public double Side => _side;

        public override FigureType FigureType => this.FigureType.Square;

        public double Diagonal => Math.Sqrt(2) * _side;

        public override double Area => Math.Pow(_side, 2);
        public override double Perimeter => _side * 4;

        public Square(double side, int figureId) : base(figureId)
        {
            this._side = side;
        }

        public override int GetAnglesCount()
        {
            return Angles;
        }
    }
}