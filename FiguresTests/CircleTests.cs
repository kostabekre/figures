using FiguresLibrary.Figures.Circle;

namespace FiguresTests;

public class CircleTests
{
    [Theory]
    [InlineData(1, 3.14)]
    [InlineData(2, 12.57)]
    [InlineData(3, 28.27)]
    public void CircleAreaTest(float r, double answer)
    {
        ICircle circle = new SimpleCircle(r);
        
        double tollerance = 0.01f;
        double difference = Math.Abs(circle.Area - answer);
        
        Assert.True(difference < tollerance);
    }
}