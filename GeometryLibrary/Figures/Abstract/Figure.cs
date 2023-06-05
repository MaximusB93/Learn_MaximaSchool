namespace GeometryLibrary.Figures.Abstract
{
    public abstract class Figure
    {
        public abstract double Area { get; }
        public abstract double Perimeter { get; }
        public abstract FigureType FigureType { get; }
        public int FigureId { get; }

        public string Title => FigureType.ToString();

        public Figure(int figureId)
        {
            FigureId = figureId;
        }

        public abstract int GetAnglesCount();

        public string GetTitle()
        {
            return $"{FigureId}: {Title}";
        }

        public override string ToString()
        {
            return GetTitle();
        }
    }

    public enum FigureType
    {
        Circle,
        Square,
        Triangle,
        Cube
    }
}