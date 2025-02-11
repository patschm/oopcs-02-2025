namespace DeTorenVanPisa;

class Etage
{
    public int EtageNummer { get; set; }
    private static Lift _lift = new Lift();

    public void RoepLift()
    {
        _lift.RoepLift(EtageNummer);
    }

    // Het static zijn van deze methode is eigenlijk onzin!
    public static void WaarIsDeLift()
    {
        // Vanuit static methods kun je geen instance members benaderen.
        // this-keyword heeft geen betekenis.
        Console.WriteLine($"De lift is nu op de {_lift.HuidigeVerdieping}e verdieping");
    }

    // Om static fields van een initiele waarde te voorzien.
    static Etage()
    {
        
    }
}
