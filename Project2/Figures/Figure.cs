using System;

namespace Project2.Figures
{
    public class Figure
    {
        public virtual double Area { get; set; }
        public virtual double Perimeter { get; set; }

        public virtual string GetTitle()
        {
            return "Unkown Figure";
        }
    }

    enum FigureType
    {
        Circle,
        Square,
        Triangle
    }
}