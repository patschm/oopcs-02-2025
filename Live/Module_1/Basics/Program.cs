
namespace Basics;


internal class Program
{

    static void Main(string[] args)
    {
        // Variabelen declaraties
        // Datatype naam;
        const float PI = 3.14F;
        int x = 1_000_000;
        string name = "Patrick";

        Console.WriteLine(name);

        short y = (short)x;
        Console.WriteLine(x++);
        long z = x;

        float w = 1_000_000.0F;
        bool v = true;

        double u = 10 / 20D;
        Console.WriteLine(u);

        // 0001 & 0010
        Console.WriteLine(1 ^ 2);

        string? names2 = null;
        
        //names2 = Console.ReadLine();

        Console.WriteLine(names2?.Length);

        Nullable<int> ageFull = null;
        int? age = 35;

        Console.WriteLine(age ?? 42);

    }
}
