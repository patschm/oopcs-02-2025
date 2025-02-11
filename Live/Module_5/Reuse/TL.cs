namespace Reuse;

// De TL erft nu van Lamp
// Dit bevordert het hergebruik.
// Je mag maar van een class tegelijk erven. Multiple inheritance wordt niet ondersteund
// Je mag wel zo diep gaan als je wilt. Dus ik kan wel van TL erven. Tenzij TL sealed
// sealed class TL : Lamp
// Gebruik overerving als je de vraag "is het een" positief kunt beantwoorden
 class TL : Lamp
{
    public int KnipperCount { get; set; }
    
    // Met override activeer ik polymorf gedrag.
    public override void Aan()
    {
        StartUp();
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De TL brandt met intensiteit {Intensiteit} lumen");
        Console.ResetColor();
    }
    private void StartUp()
    {
        for (int i = 0; i < KnipperCount; i++)
        {
            Console.BackgroundColor = Kleur;
            Console.WriteLine($"Knipper");
            Task.Delay(100).Wait();
            Console.ResetColor();
            Console.Clear();
        }
    }
    public TL()
    {
        Wattage = 25;
    }
}
