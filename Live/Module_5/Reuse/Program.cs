namespace Reuse;

internal class Program
{
    static void Main(string[] args)
    {
        
        // Dit is generaliseren. Ik beschouw de TL als een Lamp.
        Lamp t1 = new TL { Intensiteit = 100, Kleur = ConsoleColor.DarkRed, KnipperCount = 5 };

        // Ziehier de kracht van het generaliseren
        Lamp[] lampen = new Lamp[2];
        lampen[0] = t1;
        // Hier zoom ik weer in op het specifiek type. Dit moet je zoveel mogelijk proberen te vermijden.
        (t1 as TL).KnipperCount = 7;
        
        t1.Aan();

        Lamp t2 = new LEDLamp { Intensiteit = 100, Kleur = ConsoleColor.Green };
        lampen[1] = t2;
        t2.Aan();

        Console.WriteLine(t2.Wattage);

        foreach (var t in lampen)
        {
            t.Aan();
        }
    }
}
