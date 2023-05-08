using System;

namespace Project2.Figures
{
    public class Circle : Figure
    {
        private double _r;

        public double R => _r;
        public double Diameter => _r * 2;

        public override double Area => Math.PI * Math.Pow(_r, 2);
        public override double Perimeter => 2 * Math.PI * _r;

        public Circle(double r)
        {
            this._r = r;
        }

        public override string GetTitle()
        {
            return "Circle";
        }
    }
}