using FiguresLibrary.Figures.Triangle;

namespace FiguresTests;

public class TriangleTests
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(3, 2, 1)]
    [InlineData(1, 7, 5)]
    public void IsNotTriangleTest(float a, float b, float c)
    {
        Action createTriangle = () =>
        {
            new SimpleTriangle(a, b, c);
        };
        
        Assert.Throws<ArgumentException>(createTriangle);
    }
    
    [Theory]
    [InlineData(2, 2, 3)]
    [InlineData(3, 2, 4)]
    [InlineData(7, 9, 3)]
    public void TriangleIsNotRightTest(float a, float b, float c)
    {
        ITriangle triangle = new SimpleTriangle(a, b, c);
        
        Assert.False(triangle.IsRightAngled);
    }
    
    [Theory]
    [InlineData(3, 4, 5)]
    [InlineData(5, 12, 13)]
    [InlineData(7, 24, 25)]
    public void TriangleIsRightTest(float a, float b, float c)
    {
        ITriangle triangle = new SimpleTriangle(a, b, c);
        
        Assert.True(triangle.IsRightAngled);
    }

    [Theory]
    [InlineData(3, 4, 2, 2.905)]
    [InlineData(5, 7 , 4, 9.798)]
    [InlineData(7, 3, 5, 6.495)]
    public void TriangleHasAreaTest(float a, float b, float c, double answer)
    {
        ITriangle triangle = new SimpleTriangle(a, b, c);

        double tolerance = 0.001;
        double difference = Math.Abs(answer - triangle.Area); 
        
        Assert.True(difference < tolerance);
    }
}