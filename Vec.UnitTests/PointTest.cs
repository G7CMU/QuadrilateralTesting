using Geometry;

namespace Vec.UnitTests;

internal class PointTest
{
    [Test]
    public void create00Point()
    {
        Point p = new Point(0, 0);
        Assert.That(p.ToString(), Is.EqualTo("(0, 0)"));
    }

    [Test]
    public void checkSamePoint()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 0);

        Assert.That(p1.ToString(), Is.EqualTo(p2.ToString()));
    }

    [Test]
    public void checkDifferPoint()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 1);

        Assert.That(p1.ToString(), Is.Not.EqualTo(p2.ToString()));
    }

    [Test]
    public void checkDistanceFrom00To10()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(1, 0);

        double result = 1.0d;

        Assert.That(p1.DistanceTo(p2), Is.EqualTo(result));
    }

    [Test]
    public void checkDistanceFrom00To11()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(1, 1);

        double result = Math.Sqrt(2);

        Assert.That(p1.DistanceTo(p2), Is.EqualTo(result));
    }
}
