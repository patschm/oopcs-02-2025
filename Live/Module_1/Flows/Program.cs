namespace Flows;

internal class Program
{
    static void Main(string[] args)
    {
        // Goed voor range checks
        if (true)
        {
        }
        else if (false)
        {
        }

        int x = 3;

        // Test concrete waarden.
        switch (x)
        {
            case  < 0:
            case 0:
                Console.WriteLine("nul");
                break;
            case 1:
                Console.WriteLine("een");
                break;
            case 2:
                Console.WriteLine("twee");
                break;
            default:
                Console.WriteLine("anders");
                break;
        }

        // Als je precies weet hoe vaak je iets moet herhalen
        for (int i = 0; i < 30; i = i + 3)
        {
            if (i == 12) continue;
            Console.WriteLine(i);
        }

        int z = 5;

        // Beide loops gebruik je als je NIET weet hoe vaak iets herhaald moet worden.
        // Voert iets 0 of meer keer uit.
        while (z < 10)
        {
            Console.WriteLine(z++);
        }

        // Voert iets 1 of meer keer uit.
        do
        {
            Console.WriteLine(z++);
        }
        while (z < 20);
    }
}
