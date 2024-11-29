using Geometry;
namespace Vec.UnitTests;
internal class Vec2Test
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Create00_to_10Vector()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(1, 0);
        Vector vector = new Vector(p1, p2);
        Assert.That(vector.ToString(), Is.EqualTo("(1, 0)"));
    }

    [Test]
    public void Create00Vector()
    {
        Point p1 = new Point(1, 0);
        Point p2 = new Point(1, 0);
        Vector vector = new Vector(p1, p2);
        Assert.That(vector.ToString(), Is.EqualTo("(0, 0)"));
    }
}