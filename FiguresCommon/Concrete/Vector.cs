namespace FiguresCommon.Concrete;

/// <summary>
/// Определение вектора на плоскости.
/// </summary>
public struct Vector
{
    private readonly Point _startPoint;
    private readonly Point _endPoint;

    /// <summary>
    /// Значение вектора (линия).
    /// </summary>
    public (Point, Point) Line => (_startPoint, _endPoint);

    /// <summary>
    /// Длина вектора.
    /// </summary>
    public double Length => Math.Sqrt(Math.Pow(_endPoint.X - _startPoint.X, 2) + Math.Pow(_endPoint.Y - _startPoint.Y, 2));

    public Vector(Point startPoint, Point endPoint)
    {
        _startPoint = startPoint;
        _endPoint = endPoint;
    }
}
