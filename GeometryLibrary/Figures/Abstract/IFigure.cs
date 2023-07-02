namespace GeometryLibrary.Figures.Abstract
{
    public interface IFigure
    {
        public double Area { get; }

        public double Perimeter { get; }

        public int GetAnglesCount();

        public double GetSquare();
    }
}