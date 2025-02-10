namespace DeFabriek;



internal class Program
{
    static void Main(string[] args)
    {
        // Virtuele Big Bang

        // l1 is een object
        Lamp l1 = new Lamp(50000, ConsoleColor.DarkGreen);
        //l1.intensiteit = 200;
        //l1.kleur = ConsoleColor.Yellow;
        l1.Aan();

        Lamp l2 = new Lamp();
        l2.Aan();


        Lamp l3 = new Lamp { Intensiteit = 600, Kleur= ConsoleColor.Red };
        l3.Aan();


        //l3.intensiteit = 4_000_000_000;
        //l3.SetIntensiteit(900);
        l3.Intensiteit = 800;
        l3.Aan();

        //Console.WriteLine(l3.GetIntensiteit());
        Console.WriteLine(l3.Intensiteit);
        // Big crunch
    }
}


