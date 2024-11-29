using Geometry;

namespace Vec.UnitTests;
internal class TriangleTest
{
    const double OFFSET = 0.1;
    [Test]
    public void create00_01_10Triangle()
    {
        Triangle t = new Triangle(
            new Point(0, 0),
            new Point(1, 0),
            new Point(0, 1)
        );

        Assert.That(t.ToString(), Is.EqualTo("T[(0, 0), (1, 0), (0, 1)]"));
    }

    [Test]
    public void areaOf00_04_40()
    {
        Triangle t = new Triangle(
            new Point(0, 0),
            new Point(4, 0),
            new Point(0, 4)
        );

        double result = 8d;

        Assert.That(t.Area(), Is.EqualTo(result));
    }

    [Test]
    public void areaOf00_03_40()
    {
        Triangle t = new Triangle(
            new Point(0, 0),
            new Point(0, 3),
            new Point(4, 0)
        );

        double result = 6d;

        Assert.That(t.Area(), Is.EqualTo(result));
    }

    [Test]
    public void perimeterOf00_03_40()
    {
        Triangle t = new Triangle(
            new Point(0, 0),
            new Point(0, 3),
            new Point(4, 0)
        );

        double result = 12;

        Assert.That(t.Perimeter(), Is.EqualTo(result));
    }

    [Test]
    public void perimeterOf00_40_04()
    {
        Triangle t = new Triangle(
            new Point(0, 0),
            new Point(4, 0),
            new Point(0, 4)
        );

        double result = 4 + 4 + 4 * Math.Sqrt(2);

        Assert.That(t.Perimeter(), Is.EqualTo(result));
    }

    [Test]
    public void validateTriangleFrom3PointOnLine()
    {
        Triangle t = new Triangle(
            new Point(0, 0),
            new Point(4, 0),
            new Point(5, 0)
        );

        Assert.That(t.IsValid(), Is.EqualTo(false));
    }

    [Test]
    public void validateValidTriangle()
    {
        Triangle t = new Triangle(
            new Point(0, 0),
            new Point(4, 0),
            new Point(5, 5)
        );

        Assert.That(t.IsValid(), Is.EqualTo(true));
    }
}
