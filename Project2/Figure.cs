using System;

namespace Project2
{
    public class Figure
    {
        public virtual double Area { get; set; }
        public virtual double Perimeter { get; set; }

        public virtual string GetTitle()
        {
            return "Figure";
        }
    }

    public class Square : Figure
    {
        private double _side;
        public double Side => _side;

        public override double Area => Math.Pow(_side, 2);
        public override double Perimeter => _side * 4;

        public Square(double side)
        {
            this._side = side;
        }

        public override string GetTitle()
        {
            return "Square";
        }
    }

    public class Circle : Figure
    {
        private double _diameter;
        public double Diameter => _diameter;

        public override double Area => Math.PI * Math.Pow(_diameter, 2) / 4;
        public override double Perimeter => Math.PI * _diameter;

        public Circle(double diameter)
        {
            this._diameter = diameter;
        }

        public override string GetTitle()
        {
            return "Circle";
        }
    }
}