
namespace Reuse;

// abstract is hier verplicht als je class een abstracte member heeft.
// Hier kun je geen instantie van maken.
// Deze class is nu ook alleen nog maar bruikbaar voor generaliseren.
abstract class Lamp
{
    // Bij een protected member kunnen alleen afgeleide classen erbij (en de class zelf natuurlijk)
    public int Wattage { get; protected set; }
    private uint _intensiteit = 300;
    public uint Intensiteit
    {
        get { return _intensiteit; }
        set
        {
            if (value >= 0 && value < 1000)
            {
                _intensiteit = value;
            }
        }
    }
    public ConsoleColor Kleur { get; set; } = ConsoleColor.Yellow;

    // Met virtual geef ik aan dat dit gedrag polymorfistisch KAN zijn.
    // Afgeleide class kunnen nu dit gedrag overriden als zij dat willen.
    // Eenmaal virtual, altijd virtual. Mits een afgeleide class het virtual zijn opheft via sealed.
    // Waar override optioneel is met virtual, kan ik met abstract dit afdwingen.
    // Afgeleide classen MOETEN nu overriden
    public abstract void Aan();
    //public virtual void Aan()
    //{
    //    Console.BackgroundColor = Kleur;
    //    Console.WriteLine($"Lamp brandt met intensiteit {Intensiteit} lumen");
    //    Console.ResetColor();
    //}
}
