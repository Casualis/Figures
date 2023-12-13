using FiguresCommon.Concrete;
using NUnit.Framework;

namespace FiguresCommonTests.Concrete;

[TestFixture()]
public class VectorTests
{
    [Test()]
    public void VectorLengthTest()
    {
        // граничное условие для простого вектора = 1
        var vectorLength = new Vector(new Point(0, 0), new Point(0, 1)).Length;

        Assert.AreEqual(vectorLength, 1.0);
    }
}
