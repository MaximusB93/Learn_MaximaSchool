namespace GeometryLibrary.Figures.Abstract
{
    public abstract class ThreeDimensionFigures : Figure
    {
        public ThreeDimensionFigures(int figureId): base(figureId)
        {
        }
        
        public abstract double Volume { get; }
    }
}