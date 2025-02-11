namespace Punten;

internal class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public static Point operator+(Point p, Point q)
    {
        return new Point { X = p.X + q.X, Y = p.Y + q.Y };
    }


    public void Display()
    {
        Console.WriteLine($"({X}, {Y})");
    }
}
