namespace FiguresLibrary.Figures.Triangle;

public static class TriangleTools
{
    public static bool IsTriangle(ITriangle triangle)
    {
        if (triangle.A < triangle.B + triangle.C
            && triangle.B < triangle.C + triangle.A
            && triangle.C < triangle.B + triangle.A)
        {
            return true;
        }

        return false;
    }
    public static bool IsRightTriangle(ITriangle triangle)
    {
        return Math.Abs(MathF.Pow(triangle.C, 2) - (MathF.Pow(triangle.A, 2) + MathF.Pow(triangle.B, 2))) < 0.001;
    }
}