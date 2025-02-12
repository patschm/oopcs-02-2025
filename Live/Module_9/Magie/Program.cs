
using System.Diagnostics;
using System.Text;

namespace Magie;

internal class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point { X = 10, Y = 20 };
        Console.WriteLine(p1);
        DoeIets(p1);
        Console.WriteLine(p1);


        string s = "";
        StringBuilder sb = new StringBuilder();

        Stopwatch sw = Stopwatch.StartNew();
        sw.Start();
        for (int i = 0; i < 100_000; i++)
        {
            //s += i.ToString();
            sb.Append(i.ToString());
        }
        sw.Stop();
        Console.WriteLine(sw.Elapsed);
    }

    private static void DoeIets(Point ppp)
    {
        ppp.X = 100;
        ppp.Y = 200;
    }
}
