using FiguresCommon.Abstract;
using FiguresCommon.Enums;

namespace FiguresCommon.Services;

/// <summary>
/// Сервис для вычисления площади фигур.
/// </summary>
public class FigureService : IFigureService
{
    public (FigureType Type, Guid Id, double Square) CalculateSquare(IFigure figure)
    {
        // проверим пустой элемент
        if (figure is null)
            throw new Exception("Figure is empty!");

        return (figure.Type, figure.Id, figure.Square);
    }

    public IEnumerable<(FigureType Type, Guid Id, double Square)> CalculateSquares(IEnumerable<IFigure> figures)
    {
        // проверим пустые элементы
        if (figures.Any(f => f is null))
            throw new Exception("Collection have empty Figures!");

        foreach(var figure in figures)
        {
            yield return (figure.Type, figure.Id, figure.Square);
        }
    }

    public bool IsRectangular(IFigure figure)
    {
        // проверим пустой элемент
        if (figure is null)
            throw new Exception("Figure is empty!");

        return figure.IsRectangular;
    }
}
