using FiguresCommon.Enums;

namespace FiguresCommon.Abstract;

/// <summary>
/// Интерфейс для обработки фигур.
/// </summary>
public interface IFigureService
{
    (FigureType Type, Guid Id, double Square) CalculateSquare(IFigure figure);

    IEnumerable<(FigureType Type, Guid Id, double Square)> CalculateSquares(IEnumerable<IFigure> figures);

    bool IsRectangular(IFigure figure);
}
