
using System.Text;

namespace Generiek;

internal class Program
{
    static void Main(string[] args)
    {
        StringBuilder b = Point<int>.Create<StringBuilder>();
        b.Append("ha");

        Point<long> p1 = new Point<long> { X = 100, Y = 200 };
        Point<long> p2 = new Point<long> { X=10, Y=20 };

        Console.WriteLine($"p1={p1}, p2={p2}");
        Swap(ref p1, ref p2);
        Console.WriteLine($"p1={p1}, p2={p2}");

        double a = 10;
        double b = 20;
        Console.WriteLine($"a={a}, b={b}");
        Swap(ref a, ref b);
        Console.WriteLine($"a={a}, b={b}");

    }

    //static void Swap(ref int aa, ref int bb)
    //{
    //    int tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    //static void Swap(ref long aa, ref long bb)
    //{
    //    long tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    //static void Swap(ref ulong aa, ref ulong bb)
    //{
    //    ulong tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}
    //static void Swap(ref float aa, ref float bb)
    //{
    //    float tmp = aa;
    //    aa = bb;
    //    bb = tmp;
    //}

    // T is een generiek type. Swap is nu een generieke procedure
    static void Swap<T>(ref T aa, ref T bb)
    {
        T tmp = aa;
        aa = bb;
        bb = tmp;
    }
}
