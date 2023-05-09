using System;

namespace Project2.Figures
{
    public class Square : Figure
    {
        private double _side;
        public double Side => _side;
        
        public override FigureType FigureType => FigureType.Square;

        public double Diagonal => Math.Sqrt(2) * _side;

        public override double Area => Math.Pow(_side, 2);
        public override double Perimeter => _side * 4;

        public Square(double side,int figureId): base( figureId)
        {
            this._side = side;
        }

    }
}