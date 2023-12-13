using FiguresCommon.Concrete;
using FiguresCommon.Enums;

namespace FiguresCommon.Abstract;

/// <summary>
/// Интерфейс описания фигуры.
/// </summary>
public interface IFigure
{
    Guid Id { get; }

    FigureType Type { get; }

    IReadOnlyCollection<Vector> Dimensions { get; }

    double Square { get; }

    bool IsRectangular { get; }
}
