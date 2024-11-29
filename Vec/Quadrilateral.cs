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
        double area_AC = 0,
            area_BD = 0;
        // div by AC
        Triangle t1_AC = new Triangle(A, B, C);
        Triangle t2_AC = new Triangle(A, D, C);

        if (t1_AC.IsValid() && t2_AC.IsValid())
            area_AC = t1_AC.Area() + t2_AC.Area();

        // div by BD
        Triangle t1_BD = new Triangle(A, B, D);
        Triangle t2_BD = new Triangle(B, C, D);
        if (t1_BD.IsValid() && t2_BD.IsValid())
            area_BD = t1_BD.Area() + t2_BD.Area();

        return Math.Max(area_AC, area_BD);
    }

    public Boolean IsValid()
    {
        if (A == null || B == null || C == null || D == null) return false;
        if (A.ToString() ==  B.ToString()) return false;
        if (A.ToString() ==  C.ToString()) return false;
        if (A.ToString() ==  D.ToString()) return false;
        if (B.ToString() ==  C.ToString()) return false;
        if (C.ToString() ==  D.ToString()) return false;
        return true;
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