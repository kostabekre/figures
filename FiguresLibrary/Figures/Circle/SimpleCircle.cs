namespace FiguresLibrary.Figures.Circle;

public class SimpleCircle : ICircle
{
    public float Radius { get; }
    
    public SimpleCircle(float radius)
    {
        Radius = radius;
        
        Area = GetArea();
    }

    private double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double Area { get; }
}