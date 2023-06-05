using System.Reflection.Metadata;
using GeometryLibrary.Figures.Abstract;

namespace GeometryCalculator
{
    public class Rectangle : ITwoDimensionFigures, IThreeDimensionFigures
    {
        private int _a;
        private int _b;
        public double Area { get; }
        public double Perimeter { get; }

        public int FigureId { get; }
        public INamable.FigureType figureType { get; }
        public string Name { get; }

        public Rectangle(string name, int a, int b)
        {
            Name = name;
            _a = a;
            _b = b;
        }

        public int GetAnglesCount()
        {
            throw new System.NotImplementedException();
        }

        public double GetSquare()
        {
            throw new System.NotImplementedException();
        }

        public double Volume { get; }
    }
}