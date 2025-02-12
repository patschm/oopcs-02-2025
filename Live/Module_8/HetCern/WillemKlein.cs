namespace HetCern;

delegate int Berekening(int x, int y);

internal class WillemKlein
{
    public void Bereken(Berekening reken, int a, int b)
    {
        Console.WriteLine("Willem gaat nu rekenen...");
        int result = reken(a, b);


        Console.WriteLine($"Eureka! Het antwoord is {result}");
    }
}
