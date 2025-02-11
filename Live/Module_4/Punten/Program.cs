namespace Punten;

internal class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point { X = 10, Y = 20 };
        p1.Display();

        Point p2 = new Point { Y = 100, X = 200 };
        p2.Display();

        //Point p3 = Point.Add(p1, p2);
        Point p3 = p1 + p2;
        p3.Display();
    }
}
