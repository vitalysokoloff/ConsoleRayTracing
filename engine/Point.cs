namespace ConsoleRT;

public class Point
{
    public int X { get; private set; }
    public int Y { get; private set; }

    /// <summary>
    /// Как вектор2, но с интами вместо флоатов
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Point operator +(Point a, Point b)
    {
        return new Point(a.X + b.X, a.Y + b.Y);
    }

    public static Point operator -(Point a, Point b)
    {
        return new Point(a.X - b.X, a.Y - b.Y);
    }

    public static Point operator *(Point a, int b)
    {
        return new Point(a.X * b, a.Y * b);
    }
}