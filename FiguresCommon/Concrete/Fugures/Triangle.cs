using FiguresCommon.Enums;

namespace FiguresCommon.Concrete.Fugures;

public class Triangle : FigureBase
{
    public Triangle(IReadOnlyCollection<Vector> dimensions) : base(FigureType.Triangle, dimensions) {}

    protected override double GetSquare()
    {
        IsTriangle();

        // использование формулы Герона для площади треугольника
        var a = Dimensions.ElementAt(0).Length;
        var b = Dimensions.ElementAt(1).Length;
        var c = Dimensions.ElementAt(2).Length;

        // полупериметр
        var p = (a + b + c) / 2.0;

        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    protected override bool GetRectangular()
    {
        IsTriangle();

        // формула Пифагора
        var a = Dimensions.ElementAt(0).Length;
        var b = Dimensions.ElementAt(1).Length;
        var c = Dimensions.ElementAt(2).Length;

        return Math.Round(Math.Pow(a, 2) + Math.Pow(b, 2), 2) == Math.Round(Math.Pow(c, 2), 2);
    }

    private bool IsTriangle()
    {
        if (Dimensions.Count() != 3)
            throw new Exception($"Это не треугольник! {Type}, {Id}");

        return true;
    }
}
