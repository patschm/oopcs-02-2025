
namespace DeFabriek;

// Blauwdruk van een lamp
class Lamp
{
    // Fields. Hierin sla je de eigenschappen vaan een object op.
    // Fields zijn by default private. Als je dat niet wilt, maak je ze public
    private uint _intensiteit = 300;
    //Overboding met auto-generation properties
    //private ConsoleColor _kleur = ConsoleColor.Yellow;

    // Zo doen javanen en C+++ - erts encapsulation
    // Wij als dotnetter doen dit dus NIET
    public void SetIntensiteit(uint lm)
    {
        if (lm >= 0 && lm < 1000)
        {
            _intensiteit = lm;
        }
    }   
    public uint GetIntensiteit()
    {
        return _intensiteit;
    }

    // Dotnetters gebruiken properties om gecontroleerde toegang tot fields geven.
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

    // Auto-generating property
    public ConsoleColor Kleur { get; set; } = ConsoleColor.Yellow;

    // Methods. Hierin leggen we gedrag vast.
    public void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"Lamp brandt met intensiteit {Intensiteit} lumen");
        Console.ResetColor();
    }

    // Constructors. Zijn bedoeld om FIELDS een initeele waarde te geven.
    // Via een constructor kan ik afdwingen dat fields van buiten een waarde moeten krijgen
    public Lamp() : this(300, ConsoleColor.Yellow)
    {
        //intensiteit = 300;
        //kleur = ConsoleColor.Yellow;
    }
    public Lamp(uint intensiteit, ConsoleColor kleur)
    {
        Intensiteit = intensiteit;
        Kleur = kleur;
    }
}
