namespace DeTorenVanPisa;

internal class Program
{
    static void Main(string[] args)
    {
        Etage[] flat = new Etage[50];
        for (int i = 0; i < flat.Length; i++)
        {
            flat[i] = new Etage { EtageNummer = i };
        }

        flat[41].RoepLift();

        flat[23].RoepLift();

        foreach(var et in flat)
        {
            // Je gebruikt de class naam om static members te benaderen.
            // Daarom worden ze ook wel eens class members genoemd.
            Etage.WaarIsDeLift();
        }

    }
}
