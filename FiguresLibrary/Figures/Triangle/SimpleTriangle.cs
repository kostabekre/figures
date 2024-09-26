namespace FiguresLibrary.Figures.Triangle;

public class SimpleTriangle : ITriangle
{
    public double Area { get; init; }
    public float A { get; }
    public float B { get; }
    public float C { get; }
    public bool IsRightAngled { get; }
    
    public SimpleTriangle(float a, float b, float c)
    {
        A = a;
        B = b;
        C = c;
        
        if (TriangleTools.IsTriangle(this) == false)
        {
            throw new ArgumentException("Given sides don't create a triangle.");
        }
        
        Area = GetArea();
        IsRightAngled = TriangleTools.IsRightTriangle(this);
    }
    
    private double GetArea()
    {
        float s = GetSemiPerimeter();
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }

    private float GetSemiPerimeter()
    {
        return (A + B + C) / 2;
    }
}