namespace Geometry;

public class Triangle
{
    private Point A { get; }
    private Point B { get; }
    private Point C { get; }

    public Triangle(Point a, Point b, Point c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double Perimeter()
    {
        double AB = A.DistanceTo(B);
        double AC = A.DistanceTo(C);
        double BC = B.DistanceTo(C);
        return (double)(AB + AC + BC);
    }

    public double Area()
    {
        Vector AB = new Vector(A, B);
        Vector AC = new Vector(A, C);
        return Math.Abs(AB.CrossProduct(AC)) / 2.0;

        // --
        //double AB = A.DistanceTo(B);
        //double AC = A.DistanceTo(C);
        //double BC = B.DistanceTo(C);
        //double p = this.Perimeter() / 2.0;

        //return Math.Sqrt(p * (p - AB) * (p - AC) * (p - BC));
    }

    public override string ToString()
    {
        return "T[" + A.ToString() + ", " + B.ToString() + ", " + C.ToString() + "]";
    }
}