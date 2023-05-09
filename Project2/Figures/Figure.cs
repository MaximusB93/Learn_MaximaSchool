using System;

namespace Project2.Figures
{
    public class Figure
    {
        public virtual double Area { get; set; }
        public virtual double Perimeter { get; set; }
        public virtual FigureType FigureType { get; }
        public int FigureId { get; }

        public string Title => FigureType.ToString();

        public Figure(int figureId)
        {
            FigureId = figureId;
        }

        public string GetTitle()
        {
            return $"{FigureId}: {Title}";
        }

        
    }

    public enum FigureType
    {
        Circle,
        Square,
        Triangle
    }
}