namespace GeometryLibrary.Figures.Abstract
{
    public interface INamable<T>
    {
        public T FigureId { get; }
        public FigureType figureType { get; }
        
        string Name { get; }

        public string Title => figureType.ToString();

        public string GetTitle()
        {
            return $"{FigureId}: {Title}";
        }

        public enum FigureType
        {
            Circle,
            Square,
            Triangle,
            Cube
        }
    }
}