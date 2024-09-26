namespace FiguresLibrary.Figures.Triangle;

public interface ITriangle : IFigure
{
    public float A { get; }
    public float B { get; }
    public float C { get; }
    bool IsRightAngled { get; }
}