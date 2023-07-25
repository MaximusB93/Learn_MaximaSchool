namespace GeometryLibrary.Figures.Abstract
{
    public interface IThreeDimensionFigures<T> : IFigure, INamable<T>
    {
        public abstract double Volume { get; }
    }
}