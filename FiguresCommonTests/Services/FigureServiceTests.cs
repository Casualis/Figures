using FiguresCommon.Abstract;
using FiguresCommon.Concrete;
using FiguresCommon.Concrete.Fugures;
using NUnit.Framework;

namespace FiguresCommon.Services.Tests;

[TestFixture()]
public class FigureServiceTests
{
    [Test()]
    public void CalculateSquareTest()
    {
        // площадь должна быть равна числу пи
        var circle = new Circle(new List<Vector> { new Vector(new Point(0, 0), new Point(0, 1)) });

        var result = new FigureService().CalculateSquare(circle);

        Assert.AreEqual(Math.PI, result.Square);
    }

    [Test()]
    public void CalculateSquaresTest()
    {
        // круг
        var circle = new Circle(new List<Vector> { new Vector(new Point(0, 0), new Point(0, 1)) });
        // треугольник
        var triangle = new Triangle(new List<Vector> 
        { 
            new Vector(new Point(0, 0), new Point(0, 1)),
            new Vector(new Point(0, 0), new Point(1, 0)),
            new Vector(new Point(0, 1), new Point(1, 0))
        });

        var result = new FigureService().CalculateSquares( new List<IFigure> { circle, triangle });

        Assert.AreEqual(Math.PI, result.First(r => r.Type == Enums.FigureType.Circle).Square);
        Assert.AreEqual(1, Math.Ceiling(result.First(r => r.Type == Enums.FigureType.Triangle).Square * 2));
    }

    [Test()]
    public void IsRectangularTest()
    {
        // треугольник
        var triangle = new Triangle(new List<Vector>
        {
            new Vector(new Point(0, 0), new Point(0, 1)),
            new Vector(new Point(0, 0), new Point(1, 0)),
            new Vector(new Point(0, 1), new Point(1, 0))
        });

        Assert.AreEqual(true, new FigureService().IsRectangular(triangle));
    }
}