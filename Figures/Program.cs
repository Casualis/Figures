using FiguresCommon.Concrete;
using FiguresCommon.Concrete.Fugures;
using FiguresCommon.Services;

namespace Figures;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // треугольник
        var triangle = new Triangle(new List<Vector>
        {
            new Vector(new Point(0, 0), new Point(0, 1)),
            new Vector(new Point(0, 0), new Point(1, 0)),
            new Vector(new Point(0, 1), new Point(1, 0))
        });

        var result = new FigureService().CalculateSquare(triangle);

        Console.WriteLine("Triangle");
        Console.WriteLine($"Square {Math.Round(result.Square, 2)}");
        Console.WriteLine($"IsRectangular {triangle.IsRectangular}");

        Console.ReadKey();
    }
}