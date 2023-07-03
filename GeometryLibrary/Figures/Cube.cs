using System;
using GeometryLibrary.Figures.Abstract;

namespace GeometryLibrary.Figures
{
    public class Cube : IThreeDimensionFigures<byte>
    {
        private double _a;

        public Cube(byte figureId, double a)
        {
            _a = a;
        }

        public string Name => "Куб";
        public double Area => 6 * _a * _a;
        public double Perimeter => 8 * _a;
        public byte FigureId { get; }
        public INamable<byte>.FigureType figureType => INamable<byte>.FigureType.Cube;

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