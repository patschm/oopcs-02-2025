
namespace FuncProcs;

internal class Program
{
    static void Main(string[] args)
    {
        int getal;
        DoeIets(out getal);
        ToonGetal(getal);

        double a = 10, b = 20, c = 30;
        var result = Add(a, b, c);
        result = Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        ToonGetal(result);

        var res = Add(c:4);
        ToonGetal(res);

        WelcomScherm();
        int getal2 = GeefGetal();
        ToonGetal(getal2);
    }

        // Procedures geven niks terug. (void)
    static void WelcomScherm()
    {
        Console.WriteLine("Welkom mij deze briljante applicatie");
    }
    static void ToonGetal(int getal)
    {
        Console.WriteLine($"Het getal is {getal}");
    }

    static void ToonGetal(double getal)
    {
        Console.WriteLine($"Het getal is {getal}");
    }
    // Function geven wel iets terug (Datatype)
    static int GeefGetal()
    {
        do
        {
            Console.WriteLine("Geef een getal tussen 0 en 10");
            string? snumber = Console.ReadLine();
            if (snumber == null) return 0;
            //int number;
            if (!int.TryParse(snumber, out int number)) continue;

            if (number >= 0 && number <= 10)
            {
                return number;
            }
        }
        while (true);
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
    // Overload
    static double Add(double a, double b)
    {
        return a + b;
    }
    static double Add(double a, double b, double c)
    {
        return a + b + c;
    }
    static double Add(params double[] doubles)
    {
        return doubles.Sum();
    }
    static int Add(int a = 10, int b = 100, int c = 1000)
    {
        return a + b + c;
    }
    static void DoeIets(out int xxx)
    {
        xxx = 1000;
    }
}
