using FiguresCommon.Enums;

namespace FiguresCommon.Concrete.Fugures;

/// <summary>
/// Круг.
/// </summary>
public class Circle : FigureBase
{
    public Circle(IReadOnlyCollection<Vector> dimensions) : base(FigureType.Circle, dimensions) {}

    protected override double GetSquare()
    {
        if(Dimensions.Count() != 1)
            throw new Exception($"Это не круг! Площадь вычислить невозможно! {Type}, {Id}");

        // pi * r * r
        return Math.PI * Math.Pow(Dimensions.First().Length, 2);
    }
}
