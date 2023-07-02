using System;
using GeometryLibrary.Figures.Abstract;

namespace GeometryLibrary.Figures
{
    public class Cube : IThreeDimensionFigures
    {
        public string Name => "Куб";
        private double _a;

        public Cube(int figureId, double a)
        {
            _a = a;
        }

        public double Area => 6 * _a * _a;
        public double Perimeter => 8 * _a;
        public int FigureId { get; }
        public INamable.FigureType figureType => INamable.FigureType.Cube;

        public int GetAnglesCount()
        {
            return 8;
        }

        public double Volume => Math.Pow(_a, 3);

        public double GetSquare()
        {
            return Area;
        }
    }
}