namespace FiguresCommon.Concrete;

/// <summary>
/// Точка в пространстве (на плоскости).
/// </summary>
public struct Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
}
