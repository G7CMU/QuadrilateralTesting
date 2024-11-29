namespace Geometry;
public class Vector
{
    public double X { get; }
    public double Y { get; }

    public Vector(Point start, Point end)
    {
        X = end.X - start.X;
        Y = end.Y - start.Y;
    }

    public double CrossProduct(Vector other)
    {
        return X * other.Y - Y * other.X;
    }

    public override string ToString()
    {
        return "(" + X + ", " + Y + ")";
    }
}