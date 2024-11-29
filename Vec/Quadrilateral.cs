namespace Geometry;

public class Quadrilateral
{
    private Point A { get; }
    private Point B { get; }
    private Point C { get; }
    private Point D { get; }

    public Quadrilateral(Point a, Point b, Point c, Point d)
    {
        A = a;
        B = b;
        C = c;
        D = d;
    }

    public double Perimeter()
    {
        double AB = A.DistanceTo(B);
        double BC = B.DistanceTo(C);
        double CD = C.DistanceTo(D);
        double DA = D.DistanceTo(A);

        return AB + BC + CD + DA;
    }

    public double Area()
    {
        // div by AC
        Triangle t1_AC = new Triangle(A, B, C);
        Triangle t2_AC = new Triangle(A, D, C);
        double area_AC = t1_AC.Area() + t2_AC.Area();

        // div by BD
        Triangle t1_BD = new Triangle(A, B, D);
        Triangle t2_BD = new Triangle(B, C, D);
        double area_BD = t1_BD.Area() + t2_BD.Area();

        return Math.Max(area_AC, area_BD);
    }

    public override string ToString()
    {
        return "Q[" +
            A.ToString() + ", " +
            B.ToString() + ", " +
            C.ToString() + ", " +
            D.ToString() + "]";
    }
}