using Geometry;

namespace Vec.UnitTests;

internal class QuadrilateralTest
{
    [Test]
    public void create00_04_43_30Q()
    {
        Quadrilateral quadr = new Quadrilateral(
            new Point(0, 0),
            new Point(0, 4),
            new Point(4, 3),
            new Point(3, 0)
        );

        Assert.That(
            quadr.ToString(), 
            Is.EqualTo("Q[(0, 0), (0, 4), (4, 3), (3, 0)]")
        );
    }

    [Test]
    public void areaOf00_40_43_30Q()
    {
        Quadrilateral quadr = new Quadrilateral(
            new Point(0, 0),
            new Point(4, 0),
            new Point(4, 3),
            new Point(0, 3)
        );

        double area = 12d;

        Assert.That(
            quadr.Area(),
            Is.EqualTo(area)
        );
    }
}
