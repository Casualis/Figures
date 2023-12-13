using FiguresCommon.Abstract;
using FiguresCommon.Enums;

namespace FiguresCommon.Concrete;

/// <summary>
/// Абстрактный класс для хранения состояния фигуры.
/// </summary>
public abstract class FigureBase : IFigure
{
    private readonly Guid _id;
    private readonly FigureType _type = FigureType.None;
    private readonly IReadOnlyCollection<Vector> _dimensions = Array.Empty<Vector>();

    public Guid Id => _id;

    /// <summary>
    /// Тип фигуры.
    /// </summary>
    public FigureType Type => _type;

    /// <summary>
    /// Размерность фигуры (определяющие стороны, нормали и т.д.).
    /// </summary>
    public IReadOnlyCollection<Vector> Dimensions => _dimensions;

    /// <summary>
    /// Площадь фигуры.
    /// </summary>
    public virtual double Square { get => GetSquare(); }

    /// <summary>
    /// Является ли фигура прямоугольной.
    /// </summary>
    public virtual bool IsRectangular { get => GetRectangular(); }

    /// <summary>
    /// Конструктор делаем закрытым, чтобы не делать фабрику.
    /// Новые фигуры будут добавляться с вызовом типа и настройкой размерности (dimensions).
    /// </summary>
    /// <param name="figureType">Тип фигуры.</param>
    /// <param name="dimensions">Размерность.</param>
    protected FigureBase(FigureType figureType, IReadOnlyCollection<Vector> dimensions)
    {
        _id = Guid.NewGuid();
        _type = figureType;
        _dimensions = dimensions;

        // TODO: надо проверить, что все стороны являются сторонами фигуры.
        // Надеемся, что все вектора являются сторонами фигуры.
    }

    /// <summary>
    /// Вычисление площади фигуры.
    /// </summary>
    protected virtual double GetSquare()
    {
        return 0L;
    }

    /// <summary>
    /// Вычисляет является ли фигура прямоугольной.
    /// </summary>
    /// <remarks>Частный случай для треугольника.</remarks>
    protected virtual bool GetRectangular()
    {
        return false;
    }
}