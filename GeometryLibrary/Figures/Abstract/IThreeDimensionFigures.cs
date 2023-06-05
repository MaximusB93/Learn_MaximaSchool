namespace GeometryLibrary.Figures.Abstract
{
    public interface IThreeDimensionFigures : IFigure, INamable
    {
        public abstract double Volume { get; }
    }
}