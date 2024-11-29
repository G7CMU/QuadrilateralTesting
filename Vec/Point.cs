namespace Geometry;
public class Point
{
    public double X { get; }
    public double Y { get; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double DistanceTo(Point p)
    {
        return (double)Math.Sqrt(Math.Pow(p.X - X, 2) + Math.Pow(p.Y - Y, 2));
    }

    public override string ToString()
    {
        return "(" + X + ", " + Y + ")";
    }
}