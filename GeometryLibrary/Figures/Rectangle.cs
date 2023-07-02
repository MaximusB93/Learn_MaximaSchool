using GeometryLibrary.Figures.Abstract;

namespace GeometryLibrary.Figures
{
    public class Rectangle : ITwoDimensionFigures
    {
        private int _a;
        private int _b;
        public double Area => _a * _b;
        public double Perimeter => (_a + _b) * 2;
        private const int Angles = 4;

        public int FigureId { get; }
        public INamable.FigureType figureType => INamable.FigureType.Rectangle;
        public string Name => "Прямоугольник";

        public Rectangle(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public int GetAnglesCount()
        {
            return Angles;
        }

        public double GetSquare()
        {
            return Area;
        }
    }
}